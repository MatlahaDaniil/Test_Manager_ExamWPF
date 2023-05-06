using ClientWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace ClientWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        string User;
        public LoginWindow(string user)
        {
            InitializeComponent();
            this.User = user;
            InfoContainer.server = new Server(this);
            InfoContainer.server.Connect();
        }
        private void Username_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Username_txb.Text == "" || Username_txb.Text == "Логін")
            {
                Username_txb.Text = "Логін";
            }
        }

        private void Username_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Username_txb.Text == "" || Username_txb.Text == "Логін")
            {
                 Username_txb.Text = "";
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password_pb.Password == "password")
            {
                Password_pb.Password = "";
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password_pb.Password == "" || Password_pb.Password == "password")
            {
                Password_pb.Password = "password";
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }


        private void LogIn_btn_Click(object sender, RoutedEventArgs e)
        {
            if(Username_txb.Text != "Логін" && Password_pb.Password != "password")
            {
               

                InfoContainer.Login_Current_User = Username_txb.Text;
                InfoContainer.Password_Current_User = Password_pb.Password;

                InfoContainer.server.SendMessage($"info:|{User}|{InfoContainer.Login_Current_User}");

                InfoContainer.server.SendMessage($"Authentication: {User} {Username_txb.Text} {Password_pb.Password}");
            } 
            else
            {
                ErrorWindow error = new ErrorWindow ("Заповніть всі поля!");
                error.Owner = this;
                error.Show();
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (Username_txb.Text != "Логін" && Password_pb.Password != "password")
            {


                InfoContainer.Login_Current_User = Username_txb.Text;
                InfoContainer.Password_Current_User = Password_pb.Password;

                InfoContainer.server.SendMessage($"reg: {User} {Username_txb.Text} {Password_pb.Password}");
            }
            else
            {
                ErrorWindow error = new ErrorWindow("Заповніть всі поля!");
                error.Owner = this;
                error.Show();
            }
        }
    }
}
