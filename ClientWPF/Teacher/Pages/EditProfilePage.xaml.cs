using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientWPF.PagesForTeacher
{
    /// <summary>
    /// Логика взаимодействия для EditProfilePage.xaml
    /// </summary>
    public partial class EditProfilePage : Page
    {
        public EditProfilePage()
        {
            InitializeComponent();
        }

        private void AccPhoto_elips_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            ImageBrush image = new ImageBrush();
            image.ImageSource = new BitmapImage(new Uri(dialog.FileName));

            AccPhoto_elips.Fill =  image;
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
    }
}
