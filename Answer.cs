﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_02;
namespace exam_02
{
    public   class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

       

        public Answer(int answerId , string answerText ) { 

            AnswerId = answerId;
            AnswerText = answerText;
        
        }

        public Answer(int answerId)
        {

            AnswerId = answerId;
            

        }

        
    }
}
