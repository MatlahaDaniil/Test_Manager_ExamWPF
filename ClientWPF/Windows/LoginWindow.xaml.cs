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
        int it = 0;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Registr_btn_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registr = new RegisterWindow();
            registr.Owner = this;
            this.Visibility = Visibility.Hidden;
            registr.ShowDialog();
            this.Close();
        }

        private void Username_txb_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (it == 0)
            {
                Username_txb.Text = "";
                it++;
            }
        }
    }
}
