using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ClientWPF
{
    internal class InfoContainer
    {
        static public Server server;
        static public string Login_Current_User;
        static public string Password_Current_User;
        static public string Fullname_Current_User;
        static public string Email_Current_User;
        static public string PhoneNum_Current_User;
        static public string Schoolnum_Current_User;
        static public BitmapImage ProfileIcon_Current_User;

        public delegate void CheckUpdateProfile(string message);
        static public event CheckUpdateProfile UpdateProfile;


        public InfoContainer()
        {
            server = new Server();
            server.Connect();
        }

        static public void UpdateInfo(string message)
        {
            UpdateProfile?.Invoke(message);
        }
    }
}
