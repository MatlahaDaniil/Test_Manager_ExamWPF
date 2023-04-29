using ClientWPF.Pages;
using ClientWPF.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ClientWPF
{
    class Server
    {
        const int Localport = 1001;
        const int Remoteport = 1000;
        private byte[] bytesSend;

        LoginWindow loginWindow;

        private UdpClient client;
        private UdpClient receiver;

        private CancellationTokenSource tokenSource;
        private CancellationToken token;

        public Server(LoginWindow loginWindow = null)
        {
            bytesSend = null; 
            client = null;
            receiver = null;

            this.loginWindow = loginWindow;
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


                    if (builder.ToString().Contains("ex:"))
                    {
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            var errorWindow = new ErrorWindow(builder.ToString().Remove(0, 4));
                            errorWindow.ShowDialog();
                        });
                    }
                    else if (builder.ToString() == "successful")
                    {
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            var teacher = new TeacherAccWindow(InfoContainer.ProfileIcon_Current_User);
                            loginWindow.Hide();
                            teacher.ShowDialog();
                            loginWindow.Close();
                        });
                    }
                    else if (builder.ToString().Contains("infoString:"))
                    {
                        string[] Info = builder.ToString().Split('|');

                        InfoContainer.Fullname_Current_User = Info[1];
                        InfoContainer.Email_Current_User = Info[2];
                        InfoContainer.PhoneNum_Current_User = Info[3];
                        InfoContainer.Schoolnum_Current_User = Info[4];
                    }
                    else if (builder.ToString().Contains("img:"))
                    {
                        int q = 0;
                        int len = Convert.ToInt32(builder.ToString().Remove(0, 4));
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

                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            InfoContainer.ProfileIcon_Current_User = new BitmapImage();

                            MemoryStream ms = new MemoryStream(bytes);
                            //BitmapImage img = new BitmapImage();
                            //img.StreamSource = ms;
                            InfoContainer.ProfileIcon_Current_User.BeginInit();

                            InfoContainer.ProfileIcon_Current_User.StreamSource = ms;

                            InfoContainer.ProfileIcon_Current_User.EndInit();
                        });
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

        public async void SendMessage(byte[] message)
        {
            if (client != null)
            {
                await client.SendAsync(message, message.Length,
                    new IPEndPoint(IPAddress.Parse("127.0.0.1"), Remoteport));

            }
        }
    }
}
