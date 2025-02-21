using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int timeOfExam, int numberOfExam): base (timeOfExam, numberOfExam, TypeExam.Practical)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.WriteLine("Answers:");
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }

                Console.WriteLine($"Correct Answer: {question.RightAnswer}\n");

            }

        }
    }
}
