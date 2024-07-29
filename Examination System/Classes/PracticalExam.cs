using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int date, int number,Subject subject) : base(date, number)
        {
            Subject = subject;
        }

        public override void ShowExam()
        {

            #region Variables
            MCQ_Question[] mCQ_Question = new MCQ_Question[NumberOfQuestions];
            int Grade, correctAnswer; bool Flag;
            string Header, Body; 
            #endregion

            if (mCQ_Question.Length > 0)
            {
                for (int i = 0; i < mCQ_Question.Length; i++)
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
                        Console.WriteLine("Enter Grade");
                        Flag = int.TryParse(Console.ReadLine(), out Grade);
                    } while (Flag == false);
                    #endregion

                    #region Answers
                    Answer[] answers = new Answer[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Enter Answers {j + 1}");
                        string answerText = Console.ReadLine();
                        answers[j] = new Answer(j + 1, answerText);
                    }
                    #endregion

                    #region Correct Answer
                    do
                    {
                        Console.WriteLine("Please Enter Correct Answer:");
                        Flag = int.TryParse(Console.ReadLine(), out correctAnswer);
                    } while (Flag == false || correctAnswer == 0 || correctAnswer > 3);
                    #endregion

                    #region Collect Data
                    if (Flag)
                    {
                        mCQ_Question[i]= new MCQ_Question(Header, Body, Grade, answers, correctAnswer);
                        Console.Clear();
                    } 
                    #endregion


                }

            }

            Console.WriteLine("\nAll Questions:");
            foreach (var question in mCQ_Question)
            {
                Console.WriteLine($"\nHeader: {question.Header}");
                Console.WriteLine($"Body: {question.Body}");
                Console.WriteLine($"Mark: {question.Mark}");
                Console.WriteLine("Answers:");
                foreach (var answer in question.Answer)
                {
                    Console.WriteLine($"  {answer.ID}: {answer.Text}");
                }
            }
        }
    }
}
