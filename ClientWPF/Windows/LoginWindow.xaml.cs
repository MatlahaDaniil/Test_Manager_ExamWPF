using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public LoginWindow()
        {
            InitializeComponent();
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
    }
}
