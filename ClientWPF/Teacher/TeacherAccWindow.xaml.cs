using ClientWPF.PagesForTeacher;
using ClientWPF.PagesFromTeacher;
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

namespace ClientWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для TeacherAccWindow.xaml
    /// </summary>
    public partial class TeacherAccWindow : Window
    {
        ProfilePage profile;
        public TeacherAccWindow()
        {
            InitializeComponent();
        }

        private void Acc_btn_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Content = profile;
        }

        private void MoveWindow_MouseDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minus_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Expand_btn_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                 this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }
    }
}
