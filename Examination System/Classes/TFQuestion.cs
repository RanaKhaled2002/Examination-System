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
        public TFQuestion(string header, string body, int mark, Answer[] answer, int correctAnswer) : base(header, body, mark, answer, correctAnswer)
        {
        } 
        #endregion
    }
}
