using ClientWPF.Windows;
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

namespace ClientWPF.Teacher.TeacherWindows
{
    /// <summary>
    /// Логика взаимодействия для EditInfoForCreateTestWindow.xaml
    /// </summary>
    public partial class EditInfoForCreateTestWindow : Window
    {

        public EditInfoForCreateTestWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void NameTest_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameTest_txb.Text == "" || NameTest_txb.Text == "                 Назва тесту")
            {
                NameTest_txb.Text = "";
            }
        }

        private void NameTest_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTest_txb.Text == "" || NameTest_txb.Text == "                 Назва тесту")
            {
                NameTest_txb.Text = "                 Назва тесту";
            }
        }

        private void Subject_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Subject_txb.Text == "" || Subject_txb.Text == "           Шкільний предмет")
            {
                Subject_txb.Text = "";
            }
        }

        private void Subject_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Subject_txb.Text == "" || Subject_txb.Text == "           Шкільний предмет")
            {
                Subject_txb.Text = "           Шкільний предмет";
            }
        }

        private void NumClass_txb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumClass_txb.Text == "" || NumClass_txb.Text == "                 Номер Класу")
            {
                NumClass_txb.Text = "";
            }
        }

        private void NumClass_txb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumClass_txb.Text == "" || NumClass_txb.Text == "                 Номер Класу")
            {
                NumClass_txb.Text = "                 Номер Класу";
            }
        }

        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Test.Name = NameTest_txb.Text;
                Test.Subject = Subject_txb.Text;
                Test.ClassNum = Convert.ToInt32(NumClass_txb.Text);

                Test.UpdateInfo("update");

                this.Close();
            }
            catch (Exception)
            {
                ErrorWindow error = new ErrorWindow("Помилка! Перевірте введену вами інформацію");
                error.Owner = InfoContainer.MainTeacherWindow;
                error.Show();
            }
        }
    }
}
