using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class MCQ_Question : Question
    {
        #region Constructor
        public MCQ_Question(string header, string body, int mark, Answer[] answer, int correctAnswer) : base(header, body, mark, answer, correctAnswer)
        {
        }
        #endregion

        #region Methods

        public static MCQ_Question[] CreateMcqQuestion(int NumOfQuestion)
        {

            #region Variables
            MCQ_Question[] mCQ_Questions = new MCQ_Question[NumOfQuestion];
            int Grade, correctAnswer; bool Flag;
            string Header, Body;
            #endregion

            #region Body Of Function
            if (mCQ_Questions.Length > 0)
            {
                for (int i = 0; i < mCQ_Questions.Length; i++)
                {
                    #region Header
                    Header = $"MCQ Quetion: Question {i + 1}";
                    Console.WriteLine(Header);
                    #endregion

                    #region Body
                    Console.WriteLine("Please Enter Body Of Question: ");
                    Body = Console.ReadLine();
                    #endregion

                    #region Mark
                    do
                    {
                        Console.WriteLine("Enter Grade: ");
                        Flag = int.TryParse(Console.ReadLine(), out Grade);
                    } while (Flag == false || Grade <= 0);
                    #endregion

                    #region Answers
                    Answer[] answers = new Answer[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();
                        answers[j] = new Answer(j + 1, answerText);
                    }
                    #endregion

                    #region Correct Answer
                    do
                    {
                        Console.WriteLine("Please Enter Correct Answer:");
                        Flag = int.TryParse(Console.ReadLine(), out correctAnswer);
                    } while (Flag == false || (correctAnswer !=1 && correctAnswer !=2 &&correctAnswer != 3));
                    #endregion

                    #region Collect Data
                    if (Flag)
                    {
                        mCQ_Questions[i] = new MCQ_Question(Header, Body, Grade, answers, correctAnswer);
                        Console.Clear();
                    }
                    #endregion

                }

            }

            return mCQ_Questions; 
            #endregion
        } 

        #endregion

    }
}
