using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public class FinalExam :Exam
    {
        public FinalExam(int timeOfExam, int numberOfExam): base (timeOfExam,  numberOfExam, TypeExam.Final)
        { 
        
        }

        public override void ShowExam()
        {
            int score = 0;

            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.WriteLine("Answers:");
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }

                if (question.UserAnswer == question.RightAnswer)
                {
                    score += question.Mark;
                }
            }

            Console.WriteLine($"\nYour Grade: {score}");


        }

    }
}
