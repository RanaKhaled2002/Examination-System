using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class MCQ_Question : Question
    {
        public MCQ_Question(string header, string body, int mark, Answer[] answer,int correctAnswer) : base(header, body, mark,answer, correctAnswer)
        {
        }

    }
}
