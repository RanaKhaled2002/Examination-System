using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class PracticalExam : Exam
    {
        #region Attribute And Constructor
        private MCQ_Question[] mcq;
        public PracticalExam(int date, int number, Subject subject) : base(date, number)
        {
            Subject = subject;
            mcq = MCQ_Question.CreateMcqQuestion(NumberOfQuestions);
        }
        #endregion

        #region Methods

        public override void ShowExam()
        {
            int userAnswer;
            bool Flag;
            if (mcq.Length > 0)
            {
                for (int i = 0; i < mcq.Length; i++)
                {
                    Console.WriteLine(mcq[i].Header);
                    Console.WriteLine($"{i + 1}- {mcq[i].Body}");
                    foreach (var answer in mcq[i].Answer)
                    {
                        Console.WriteLine($"  {answer.ID}: {answer.Text}");
                    }

                    do
                    {
                        Console.WriteLine("Please Enter Your Answer {1, 2, 3}:");
                        Flag = int.TryParse(Console.ReadLine(), out userAnswer);
                    } while (Flag == false || userAnswer <= 0 || userAnswer > 3);

                    Console.Clear();
                }

                Console.WriteLine("Exam Is Finish....");
                Console.WriteLine();
                for (int i = 0; i < mcq.Length; i++)
                {
                    Console.WriteLine($"{i + 1}- {mcq[i].Body}");
                    foreach (var answer in mcq[i].Answer)
                    {
                        Console.WriteLine($"  {answer.ID}: {answer.Text}");
                    }
                    Console.WriteLine($"Correct Answer Is: {mcq[i].CorrectAnswer} ");
                    Console.WriteLine("======================================");
                    Console.WriteLine();
                }
            }
        }
            
        #endregion
    }
}
