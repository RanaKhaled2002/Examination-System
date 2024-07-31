using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal abstract class Exam
    {
        #region Attribute And Constructor
        public static int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }

        public Exam(int date, int number)
        {
            Time = date;
            NumberOfQuestions = number;
        }
        #endregion

        #region Methods
        public abstract void ShowExam(); 
        #endregion
    }
}
