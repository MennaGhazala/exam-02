using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }

        public int NumberOfQuestions { get; set; }

        public List<Questions> Questions { get; set; }
     
        public TypeExam TypeOfExam { get; set; }

        public Exam(int timeOfExam, int numberOfExam, TypeExam typeExam)
        {

            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfExam;
            Questions = new List<Questions>();
           
            TypeOfExam = typeExam;


        }
        public abstract void ShowResultExam();

        public virtual void SolveExam()
        {
            Console.WriteLine("--- Solve the Exam ---");

            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.WriteLine("Enter the Answer : ");
                int userAnswerId;

                while (!int.TryParse(Console.ReadLine(), out userAnswerId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid answer ID.");
                }

                question.UserAnswer = userAnswerId;
            }

        }
    }
}
