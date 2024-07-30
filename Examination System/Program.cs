using Examination_System.Classes;
using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10,"C#");
            subject.CreateExam();

            Console.Clear();
            Console.WriteLine("Do You Want To Start Exam Y | Or Any Key To Close Exam ");

            if(char.Parse(Console.ReadLine())=='y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.Exam.ShowExam();
                Console.WriteLine($"Elapsed Time Is = {sw.Elapsed}");
            }
        }
    }
}
