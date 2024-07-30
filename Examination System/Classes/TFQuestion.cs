using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class TFQuestion : Question
    {
        #region Attribute And Constructor
        public TFQuestion(string header, string body, int mark, Answer[] answer, int correctAnswer, int totalGrade) : base(header, body, mark, answer, correctAnswer,totalGrade)
        {
        }
        public TFQuestion(string header, string body, int mark, int correctAnswer,int totalExamGrade) : base(header, body, mark, correctAnswer,totalExamGrade)
        { }
        #endregion

        #region Methods

        public static TFQuestion[] CreateTFQuestion(int NumOfQuestion)
        {

            #region Variables
            TFQuestion[] TF_Question = new TFQuestion[NumOfQuestion];
            int Grade, correctAnswer,TotalExamGrade = 0; bool Flag;
            string Header, Body;
            #endregion

            #region Body Of Function
            if (TF_Question.Length > 0)
            {
                for (int i = 0; i < TF_Question.Length; i++)
                {
                    #region Header
                    Header = $"True Or Flase";
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
                    TotalExamGrade += Grade;
                    #endregion

                    #region Correct Answer
                    do
                    {
                        Console.WriteLine("Please Enter Correct Answer: (1 For True || 2 For False)");
                        Flag = int.TryParse(Console.ReadLine(), out correctAnswer);
                    } while (Flag == false || (correctAnswer !=1 && correctAnswer !=2));
                    #endregion

                    #region Collect Data
                    if (Flag)
                    {
                        TF_Question[i] = new TFQuestion(Header, Body, Grade, correctAnswer,TotalExamGrade);
                        Console.Clear();
                    }
                    #endregion

                }

            }

            return TF_Question;
            #endregion
        }

        #endregion
    }
}
