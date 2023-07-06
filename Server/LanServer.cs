using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.IO;

namespace Server
{
    internal class LanServer
    {
        const int Localport = 1000;
        const int Remoteport = 1001;

        private byte[] bytesSend;

        private UdpClient client;
        private UdpClient receiver;

        private CancellationTokenSource tokenSource;
        private CancellationToken token;

        TaskManagerDB_Connection db;

        public  LanServer()
        {
            client = null;
            receiver = null;
            bytesSend = null;
            db = new TaskManagerDB_Connection();
        }

        public void Connect()
        {
            if (client != null) return;

            client = new UdpClient();
            receiver = new UdpClient(Localport);

            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;

            Task task = Task.Run(ReceiveMessages, token);
        }

        private void ReceiveMessages()
        {
            IPEndPoint remotePoint = null;

            StringBuilder builder = new StringBuilder();
            try
            {
                string User = null, Login = null;
                while (true)
                {
                    if (token.IsCancellationRequested)
                        break;

                    do
                    {
                        byte[] data = receiver.Receive(ref remotePoint);
                        builder.Append(Encoding.UTF8.GetString(data));
                    } while (receiver.Available > 0);

                    if (builder.ToString().Contains("reg:"))
                    {
                        string[] Params = builder.ToString().Split(' ');
                        string answer = db.RegisterNewAcc(Params[1], Params[2], Params[3]);

                        SendMessage(answer);
                    }
                    else if (builder.ToString().Contains("Authentication"))
                    {
                        string[] Params = builder.ToString().Split(' ');
                        string answer = db.AuthenticationAcc(Params[1], Params[2], Params[3]);

                        SendMessage(answer);
                    }
                    else if (builder.ToString().Contains("edit:"))
                    {
                        string[] Params = builder.ToString().Split('|');
                        string answer = db.EditAcc(Params[1], Params[2], Params[3], Params[4], Params[5],
                            Params[6]);

                        User = Params[1];
                        Login = Params[6];
                        SendMessage(answer);
                    }
                    else if (builder.ToString().Contains("img:"))
                        SendImage(builder.ToString(), User, Login, remotePoint);
                    
                    else if (builder.ToString().Contains("info:"))
                        SendInfo(builder.ToString().Split('|'));
                    
                    builder.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                receiver = null;
            }
        }

        void SendImage(string ReceiveMessage , string User , string Login , IPEndPoint remotePoint)
        {
            int q = 0;
            int len = Convert.ToInt32(ReceiveMessage.ToString().Remove(0, 4));
            byte[] bytes = new byte[len];

            int j = 0;
            while (q < bytes.Length)
            {
                byte[] data = null;

                do
                {
                    data = receiver.Receive(ref remotePoint);
                } while (receiver.Available > 0);

                for (int i = 0; i < data.Length; i++, q++)
                {
                    if (q >= bytes.Length) break;

                    bytes[q] = data[i];
                }

                j += data.Length;
            }


            db.EditProfileIcon(User, Login, bytes);
        }

        void SendInfo(string[] Params)
        {
            SendMessage(db.GetStringInfo(Params[1], Params[2]));

            if (db.CheckProfileIcon(Params[1], Params[2]))
            {

                SendMessage(db.GetImageLength(Params[1], Params[2]));


                byte[] bytes = db.GetImage(Params[1], Params[2]);

                if (bytes.Length <= 65000)
                {
                    SendMessage(bytes);
                }
                else
                {
                    int q = 0;

                    while (q < bytes.Length)
                    {
                        byte[] peace = new byte[65000];

                        for (int j = 0; j < 65000; j++)
                        {
                            if (q >= bytes.Length) break;

                            peace[j] = bytes[q];
                            q++;
                        }
                        SendMessage(peace);
                    }
                }
            }
        }

        public async void SendMessage(string message)
        {
            if (client != null)
            {
                Thread.Sleep(100);

                bytesSend = Encoding.UTF8.GetBytes(message);
                await client.SendAsync(bytesSend, bytesSend.Length,
                    new IPEndPoint(IPAddress.Parse("127.0.0.1"), Remoteport));
            }
        }
        public async void SendMessage(byte[] message)
        {
            if (client != null)
            {
                Thread.Sleep(100);

                await client.SendAsync(message, message.Length,
                    new IPEndPoint(IPAddress.Parse("127.0.0.1"), Remoteport));

            }
        }

    }
}

