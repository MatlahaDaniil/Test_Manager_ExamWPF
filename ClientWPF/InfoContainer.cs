using ClientWPF.Student;
using ClientWPF.Windows;
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

        static public string Name_Test;
        static public string NameSubject_Test;
        static public string SchoolNum_Test;
        static public List<string> ListQuestions_Test;
        static public List<int> CountAnswers_Test;
        static public List<byte[]> ListAnswers_Test;

        static public TeacherAccWindow MainTeacherWindow = null;
        static public StudentWindow MainStudentWindow = null;

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
