using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows;

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

                        if(answer.Contains("ex:")) 
                            SendMessage(answer);
                        else if(answer == "successful")
                            SendMessage(answer);
                    }
                    if (builder.ToString().Contains("Authentication"))
                    {
                        string[] Params = builder.ToString().Split(' ');
                        string answer = db.AuthenticationAcc(Params[1], Params[2], Params[3]);

                        if (answer.Contains("ex:"))
                            SendMessage(answer);
                        else if (answer == "successful")
                            SendMessage(answer);
                    }


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

        public async void SendMessage(string message)
        {
            if (client != null)
            {

                bytesSend = Encoding.UTF8.GetBytes(message);
                await client.SendAsync(bytesSend, bytesSend.Length,
                    new IPEndPoint(IPAddress.Parse("127.0.0.1"), Remoteport));
            }
        }

    }
}

