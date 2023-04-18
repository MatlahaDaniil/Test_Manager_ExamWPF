using ClientWPF.PagesForTeacher;
using ClientWPF.PagesFromTeacher;
using ClientWPF.Teacher.Pages;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClientWPF.Teacher.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page CreateTest_Page = new CreateTestPage();
        private Page EditTest_Page = new EditTestPage();
        private Page DeleteTest_Page = new DeleteTestPage();
        private Page EditProfile_Page = new EditProfilePage();
        private Page Profile_Page = new ProfilePage();
        private Page ListStudent_Page = new ListStudentsPage();
        private Page StatisticStudents_Page = new StatisticStudentPage();

        private Page _CurPage = null;

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenCreateTest_Page
        {
            get { return new RelayCommand(() => CurPage = CreateTest_Page); }
        }

        public ICommand OpenEditTest_Page
        {
            get { return new RelayCommand(() => CurPage = EditTest_Page); }
        }

        public ICommand OpenDeleteTest_Page
        {
            get { return new RelayCommand(() => CurPage = DeleteTest_Page); }
        }

        public ICommand OpenEditProfile_Page
        {
            get { return new RelayCommand(() => CurPage = EditProfile_Page); }
        }

        public ICommand OpenProfile_Page
        {
            get { return new RelayCommand(() => CurPage = Profile_Page); }
        }

        public ICommand OpenListStudent_Page
        {
            get { return new RelayCommand(() => CurPage = ListStudent_Page); }
        }

        public ICommand OpenStatisticStudents_Page
        {
            get { return new RelayCommand(() => CurPage = StatisticStudents_Page); }
        }
    }
}
