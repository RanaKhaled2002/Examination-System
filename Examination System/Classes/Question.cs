﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class Question
    {
        #region Attribute And Constructor

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answer { get; set; }
        public int CorrectAnswer { get; set; }
        public int TotalExamGrade { get; set; }

        public Question(string header, string body, int mark, Answer[] answer, int correctAnswer,int totalGrade):this(header, body, mark, correctAnswer,totalGrade)
        {
            Answer = answer;
        }

        public Question(string header, string body, int mark, int correctAnswer,int totalGrade)
        {
            Header = header;
            Body = body;
            Mark = mark;
            CorrectAnswer = correctAnswer;
            TotalExamGrade = totalGrade;
        }

        #endregion

    }
}
