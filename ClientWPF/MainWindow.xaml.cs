using ClientWPF.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void Teacher_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            LoginWindow login = new LoginWindow();
            login.Owner = this;
            login.ShowDialog();
            this.Close();
        }

        private void Student_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            LoginWindow login = new LoginWindow();
            login.Owner = this;
            login.ShowDialog();
            this.Close();
        }

    }
}
