using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class Answer
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public Answer(int Id, string text):this(Id)
        {
            Text = text;
        }
        public Answer(int id) 
        {
            ID = id;
        }

        public override string ToString()
        {
            return $"{ID}, {Text}";
        }
    }

}
