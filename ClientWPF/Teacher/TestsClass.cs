using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF.Teacher
{
    class Test
    {
        static public int Id;
        static public string Name;
        static public string Subject;
        static public int ClassNum;

        static public Questions[] questions;
        static public Answers[] answers;

        public delegate void CheckUpdateTestInfo(string message);
        static public event CheckUpdateTestInfo UpdateTestInfo;

        static public void UpdateInfo(string message)
        {
            UpdateTestInfo?.Invoke(message);
        }
    }

    class Questions
    {
        public int Id;
        public string Question;
        public int Id_test;
    }

    class Answers
    {
        public int Id;
        public string Answer;
        public bool CorrectAnswer;
        public int IdQuestion;
    }
}
