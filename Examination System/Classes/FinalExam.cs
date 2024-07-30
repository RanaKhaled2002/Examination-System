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

        public List<TFQuestion> tfList  = new List<TFQuestion>();
        public List<MCQ_Question> mcqList = new List<MCQ_Question>() ; 
        private int TotalGrade = 0;
        private int TotalExamGrade = 0;

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
                    TFQuestion[] tf=TFQuestion.CreateTFQuestion(1);
                    TotalExamGrade += tf[0].TotalExamGrade;
                    tfList.Add(tf[0]);
                    Console.Clear();
                }
                else if(Flag && number==2)
                {
                    MCQ_Question[] mcq = MCQ_Question.CreateMcqQuestion(1);
                    TotalExamGrade += mcq[0].TotalExamGrade;
                    mcqList.Add(mcq[0]);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please Enter Correct Question Number");
                    createExamQuestion();
                }
            }
        }

        public void showTFQuestion()
        {
            int number;
            bool Flag;
            if (tfList is not null)
            {
                for (int i = 0; i < tfList.Count; i++)
                {
                    Console.WriteLine(tfList[i].Header);
                    Console.WriteLine($"{tfList[i].Body}         {tfList[i].Mark} Marks");
                    Console.WriteLine("1- True       2- Flase");
                    do
                    {
                        Console.WriteLine("Your Answer: ");
                        Flag = int.TryParse( Console.ReadLine(),out number);
                    } while (Flag== false ||(number !=1 &&number != 2));

                    if(number == tfList[i].CorrectAnswer)
                    {
                        TotalGrade += tfList[i].Mark;
                    }
                    Console.Clear();
                }
            }
        }

        public void showMCQQuestion()
        {
            int userAnswer;
            bool Flag;
            if (mcqList is not null)
            {
                for(int i=0;i<mcqList.Count;i++)
                {
                    Console.WriteLine(mcqList[i].Header);
                    Console.WriteLine($"{i + 1}- {mcqList[i].Body}         {mcqList[i].Mark} Marks");
                    foreach (var answer in mcqList[i].Answer)
                    {
                        Console.WriteLine($"  {answer.ID}: {answer.Text}");
                    }

                    do
                    {
                        Console.WriteLine("Please Enter Your Answer {1, 2, 3}:");
                        Flag = int.TryParse(Console.ReadLine(), out userAnswer);
                    } while (Flag == false || (userAnswer !=1 && userAnswer != 2 && userAnswer != 3));

                    if(userAnswer == mcqList[i].CorrectAnswer)
                    {
                        TotalGrade += mcqList[i].Mark;
                    }

                    Console.Clear();
                    
                }
            }
        }

        public override void ShowExam()
        {
            showTFQuestion();
            showMCQQuestion();
            Console.WriteLine("Exam Is Finish");
            Console.WriteLine();
            for (int i = 0; i < tfList.Count; i++)
            {
                Console.WriteLine(tfList[i].Header);
                Console.WriteLine($"{tfList[i].Body}");
                Console.WriteLine("1- True       2- Flase");
                
                if (tfList[i].CorrectAnswer == 1)
                {
                    Console.WriteLine($"The Correct Answer Is: True");
                }
                else
                {
                    Console.WriteLine($"The Correct Answer Is: Flase");

                }

                Console.WriteLine();
            }

            for (int i = 0; i < mcqList.Count; i++)
            {
                Console.WriteLine(mcqList[i].Header);
                Console.WriteLine($"{mcqList[i].Body}");
                foreach (var answer in mcqList[i].Answer)
                {
                    Console.WriteLine($"  {answer.ID}: {answer.Text}");
                }

                foreach (var answer in mcqList[i].Answer)
                {
                    if (mcqList[i].CorrectAnswer == answer.ID)
                    {
                        Console.WriteLine($"The Correct Answer Is: {answer.Text}");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Your Grade Is: {TotalGrade} / {TotalExamGrade}");
        } 

        #endregion
    }
}
