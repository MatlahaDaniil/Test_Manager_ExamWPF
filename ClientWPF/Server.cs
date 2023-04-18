using ClientWPF.Pages;
using ClientWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

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

        public Server(LoginWindow loginWindow= null)
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
                    else if(builder.ToString() == "successful")
                    {
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            var teacher = new TeacherAccWindow();
                            loginWindow.Hide();
                            teacher.ShowDialog();
                            loginWindow.Close();
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
    }
}
