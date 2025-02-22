﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public class MCQQuestion: Questions
    {

        public MCQQuestion( string body, int mark,List <Answer>  answers,int rightAnswer)
         : base("Choose the correct option", body, mark)
        {
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"    {Header}");
            Console.WriteLine($"-- {Body}");
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer.AnswerId + ".  " + answer.AnswerText);
            }

        }
    }
}
