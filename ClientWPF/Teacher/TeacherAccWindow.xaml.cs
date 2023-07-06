using ClientWPF.PagesForTeacher;
using ClientWPF.PagesFromTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        Timer timer;

        public TeacherAccWindow(BitmapImage image = null)
        {
            InitializeComponent();

            if(image!= null)
            {
                ImageBrush imageBrush = new ImageBrush(image);
                AccPhoto_elips.Fill = imageBrush;
            }

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            
            InfoContainer.UpdateProfile += InfoContainer_UpdateProfile;

            InfoContainer.MainTeacherWindow = this;
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() => TimeBlock.Text = DateTime.Now.ToShortTimeString());
        }

        private void InfoContainer_UpdateProfile(string message)
        {
            if (InfoContainer.ProfileIcon_Current_User != null)
            {
                ImageBrush imageBrush = new ImageBrush(InfoContainer.ProfileIcon_Current_User);
                AccPhoto_elips.Fill = imageBrush;
            }
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
