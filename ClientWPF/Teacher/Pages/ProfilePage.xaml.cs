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

namespace ClientWPF.PagesFromTeacher
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();

            if (InfoContainer.Fullname_Current_User != null)
            { 
                Fullname_txb.Text = InfoContainer.Fullname_Current_User;
                Email_txb.Text = InfoContainer.Email_Current_User;
                NumPhone_txb.Text = InfoContainer.PhoneNum_Current_User;
                NumSchool_txb.Text = InfoContainer.Schoolnum_Current_User;
            }
            if(InfoContainer.ProfileIcon_Current_User != null) 
            {
                ImageBrush brush = new ImageBrush(InfoContainer.ProfileIcon_Current_User);
                AccPhoto_elips.Fill = brush;
            }

            InfoContainer.UpdateProfile += InfoContainer_UpdateProfile;
        }

        private void InfoContainer_UpdateProfile(string message)
        {
            if (message == "update")
            {
                if (InfoContainer.Fullname_Current_User != null)
                {
                    Fullname_txb.Text = InfoContainer.Fullname_Current_User;
                    Email_txb.Text = InfoContainer.Email_Current_User;
                    NumPhone_txb.Text = InfoContainer.PhoneNum_Current_User;
                    NumSchool_txb.Text = InfoContainer.Schoolnum_Current_User;
                }
                if (InfoContainer.ProfileIcon_Current_User != null)
                {
                    ImageBrush brush = new ImageBrush(InfoContainer.ProfileIcon_Current_User);
                    AccPhoto_elips.Fill = brush;
                }
            }
        }
    }
}
