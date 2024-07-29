using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class FinalExam : Exam
    {
        #region Attribute And Constructor
        private TFQuestion[] tf;
        private MCQ_Question[] mcq; 
        public FinalExam(int date, int number, Subject subject) : base(date, number)
        {
            Subject = subject;
            createExamQuestion();
        }
        #endregion

        #region Methods
        public void createExamQuestion()
        {
            int number;
            bool Flag;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                do
                {
                    Console.WriteLine($"Please Choose Type Of Question Number({i + 1}) (1 For True Or False || 2 For MCQ)");
                    Flag =int.TryParse( Console.ReadLine(), out number );
                } while (Flag == false);
                if(Flag && number==1)
                {
                    tf = TFQuestion.CreateTFQuestion(1);
                    Console.Clear();
                }
                else if(Flag && number==2)
                {
                    mcq = MCQ_Question.CreateMcqQuestion(1);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please Enter Correct Question Number");
                    createExamQuestion();
                }
            }
        }

        public override void ShowExam()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
