using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answer {  get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string header, string body, int mark, Answer[] answer,int correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answer = answer;
            CorrectAnswer = correctAnswer;
        }
        
    }
}
