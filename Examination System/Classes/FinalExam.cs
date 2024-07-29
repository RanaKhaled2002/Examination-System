﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Classes
{
    internal class FinalExam : Exam
    {
        #region Attribute And Constructor
        public FinalExam(int date, int number, Subject subject) : base(date, number)
        {
            Subject = subject;
        }
        #endregion

        #region Methods
        public override void ShowExam()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
