using ClientWPF.Pages;
using Microsoft.Win32;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Reflection;
using ClientWPF.Windows;

namespace ClientWPF.PagesForTeacher
{
    /// <summary>
    /// Логика взаимодействия для EditProfilePage.xaml
    /// </summary>
    public partial class EditProfilePage : Page
    {
        private BitmapImage ImageProfile;
        public EditProfilePage()
        {
            InitializeComponent();

            if (InfoContainer.Fullname_Current_User != null  &&
                InfoContainer.Email_Current_User != null     &&
                InfoContainer.PhoneNum_Current_User != null) 
            {
                if(InfoContainer.ProfileIcon_Current_User != null)
                    ImageProfile = InfoContainer.ProfileIcon_Current_User;

                FullName_txb.Text = InfoContainer.Fullname_Current_User;
                email_txb.Text = InfoContainer.Email_Current_User;
                NumPhone_txb.Text = InfoContainer.PhoneNum_Current_User;
                NumSchool_txb.Text = InfoContainer.Schoolnum_Current_User.ToString();
            }
        }

        private void AccPhoto_elips_Click(object sender, RoutedEventArgs e)
        {
            ImageProfile = null; 

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            ImageBrush brush = new ImageBrush();

            brush.ImageSource = new BitmapImage(new Uri(dialog.FileName));

            ImageProfile = new BitmapImage(new Uri(dialog.FileName));

            AccPhoto_elips.Fill =  brush;
        }

        private void FullName_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FullName_txb.Text == "П.І.Б.")
                FullName_txb.Text = "";
        }

        private void FullName_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FullName_txb.Text == "")
                FullName_txb.Text = "П.І.Б.";
        }

        private void email_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email_txb.Text == "Пошта")
                email_txb.Text = "";
        }

        private void email_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email_txb.Text == "")
                email_txb.Text = "Пошта";
        }

        private void NumPhone_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumPhone_txb.Text == "Номер Телефону")
                NumPhone_txb.Text = "";
        }

        private void NumPhone_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumPhone_txb.Text == "")
                NumPhone_txb.Text = "Номер Телефону";
        }

        private void NumSchool_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumSchool_txb.Text == "Номер Школи")
                NumSchool_txb.Text = "";
        } 

        private void NumSchool_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumSchool_txb.Text == "")
                NumSchool_txb.Text = "Номер Школи";
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

            byte[] profileIcon = null;

            if(ImageProfile != null)
            {
                InfoContainer.ProfileIcon_Current_User = ImageProfile;

                MemoryStream memStream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(ImageProfile));
                encoder.Save(memStream);

                profileIcon = memStream.ToArray();
            }

            InfoContainer.server.SendMessage($"edit:|Teacher|{FullName_txb.Text}|{email_txb.Text}|{NumPhone_txb.Text}|" +
                                               $"{NumSchool_txb.Text}|{InfoContainer.Login_Current_User}");

            InfoContainer.Fullname_Current_User = FullName_txb.Text;
            InfoContainer.Email_Current_User = email_txb.Text;
            InfoContainer.PhoneNum_Current_User = NumPhone_txb.Text;
            InfoContainer.Schoolnum_Current_User = NumSchool_txb.Text;

            if (profileIcon != null)
            {
                Thread.Sleep(100);
                InfoContainer.server.SendMessage($"img: {profileIcon.Length}");

                Thread.Sleep(70);

                if (profileIcon.Length <= 65000)
                {
                    InfoContainer.server.SendMessage(profileIcon);
                }
                else
                {
                    int q = 0;

                    while (q < profileIcon.Length)
                    {
                        byte[] peace = new byte[65000];

                        for (int j = 0; j < 65000; j++)
                        {
                            if (q >= profileIcon.Length) break;

                            peace[j] = profileIcon[q];
                            q++;
                        }
                        InfoContainer.server.SendMessage(peace);
                    }
                }
            }

            InfoContainer.UpdateInfo("update");

            InfoWindow infoWindow = new InfoWindow("Всі данні збережено!");
            infoWindow.Show();
        }
    }
}
