using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class Subject
    {
        #region Attribute And Constructor
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int _id, string _name)
        {
            ID = _id;
            SubjectName = _name;
        }
        #endregion

        #region Methods
        public void CreateExam()
        {
            #region Variables
            int ExamNumber, NumberOfQuestion;
            int Time;
            bool Flag1, Flag2, Flag3;
            #endregion

            #region Choose Type Of Exam
            do
            {
                Console.WriteLine("Please Enter Type Of Exam You Want To Create (1 For Practical And 2 For Final):");
                Flag1 = int.TryParse(Console.ReadLine(), out ExamNumber);
            } while (Flag1 == false);
            #endregion

            #region Time Of Exam
            do
            {
                Console.WriteLine("Please Enter Total Time Of Exam In Minutes: ");
                Flag2 = int.TryParse(Console.ReadLine(), out Time);
            } while (Flag2 == false);
            #endregion

            #region Number Of Question
            do
            {
                Console.WriteLine("Please Enter Number Of Questions:");
                Flag3 = int.TryParse(Console.ReadLine(), out NumberOfQuestion);
            } while (Flag3 == false);
            #endregion

            #region Enter Exam
            if (Flag1 && Flag2 && Flag3 && ExamNumber == 1)
            {
                Console.Clear();
                Exam = new PracticalExam(Time, NumberOfQuestion, this);
            }
            else if (Flag1 && Flag2 && Flag3 && ExamNumber == 2)
            {
                Console.Clear();
                Exam = new FinalExam(Time, NumberOfQuestion, this);
            }
            else
            {
                Console.WriteLine("Please Enter Correct Exam Number 1 Or 2.");
                Console.WriteLine("=============================================");
                Console.WriteLine();
                CreateExam();
            }
            #endregion
        } 


        #endregion
    }
}
