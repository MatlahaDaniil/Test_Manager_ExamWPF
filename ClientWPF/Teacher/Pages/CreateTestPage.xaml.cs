using ClientWPF.Teacher.TeacherWindows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientWPF.Teacher.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateTestPage.xaml
    /// </summary>
    public partial class CreateTestPage : Page
    {
        public CreateTestPage()
        {
            InitializeComponent();

            Test.UpdateTestInfo += Test_UpdateTestInfo;
        }

        private void Test_UpdateTestInfo(string message)
        {
            if(message == "update")
            {
                TestName_txb.Text = Test.Name;
                Subject_txb.Text = Test.Subject;
                NumClass_txb.Text = Test.ClassNum.ToString();
            }
        }

        private void AddQuestion_btn_Click(object sender, RoutedEventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            addQuestion.Owner = InfoContainer.MainTeacherWindow;
            addQuestion.ShowDialog();
        }

        private void AddTestInfo_btn_Click(object sender, RoutedEventArgs e)
        {
            EditInfoForCreateTestWindow ed_Info = new EditInfoForCreateTestWindow();
            ed_Info.Owner = InfoContainer.MainTeacherWindow;
            ed_Info.ShowDialog();
        }
    }
}
