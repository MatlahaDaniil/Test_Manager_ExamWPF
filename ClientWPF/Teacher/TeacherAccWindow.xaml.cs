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
using static System.Net.Mime.MediaTypeNames;

namespace ClientWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для TeacherAccWindow.xaml
    /// </summary>
    public partial class TeacherAccWindow : Window
    {
        ProfilePage profile;
        public TeacherAccWindow(BitmapImage image = null)
        {
            InitializeComponent();

            if(image!= null)
            {
                ImageBrush imageBrush = new ImageBrush(image);
                AccPhoto_elips.Fill = imageBrush;
            }

            InfoContainer.UpdateProfile += InfoContainer_UpdateProfile;
        }

        private void InfoContainer_UpdateProfile(string message)
        {
            if (InfoContainer.ProfileIcon_Current_User != null)
            {
                ImageBrush imageBrush = new ImageBrush(InfoContainer.ProfileIcon_Current_User);
                AccPhoto_elips.Fill = imageBrush;
            }
        }

        private void Acc_btn_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Content = profile;
        }

        private void MoveWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

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
