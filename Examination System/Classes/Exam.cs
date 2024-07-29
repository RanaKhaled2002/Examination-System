using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }

        public Exam(int date , int number) 
        {
            Time = date;
            NumberOfQuestions = number;
        }

        public abstract void ShowExam();
    }
}
