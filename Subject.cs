using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public class Subject
    {
        public int SubjectId {  get; set; }
        public string SubjectName { get; set; }

        public Exam Exam  { get; set; }
        public Subject(int subjuctId , string subjectName ) { 
            SubjectId = subjuctId;
            SubjectName = subjectName;
            Exam = null;
        }
        

        public void CreateExam()
        {



            Console.Write("Enter Exam Type (1: Final, 2: Practical): ");
            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType))
            {
                Console.WriteLine("Invalid input. Please enter a valid Exam Type.");
            }
            Console.Write("Enter Exam Time (minutes): ");

            int time;

            while (!int.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("Invalid input. Please enter a valid .");
            }
           

            Console.Write("Enter Number of Questions: ");
            int numQuestions;
            while (!int.TryParse(Console.ReadLine(), out numQuestions))
            {
                Console.WriteLine("Invalid input. Please enter a valid .");
            }


            this.Exam = examType == 1 ? new FinalExam(time, numQuestions) : new PracticalExam(time, numQuestions);
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write("Enter Exam Type (1: mcq , 2: True or Flase): ");
                int QuestionType;

                while (!int.TryParse(Console.ReadLine(), out QuestionType))
                {
                    Console.WriteLine("Invalid input. Please enter a valid .");
                }


                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark;

                while (!int.TryParse(Console.ReadLine(), out mark))
                {
                    Console.WriteLine("Invalid input. Please enter a valid .");
                }

                Console.Write("Enter Number of Answers: ");
                int numAnswers;

                while (!int.TryParse(Console.ReadLine(), out numAnswers))
                {
                    Console.WriteLine("Invalid input. Please enter a valid .");
                }

                List<Answer> answers = new List<Answer>();
                for (int j = 0; j < numAnswers; j++)
                {
                    Console.Write($"Enter Answer {j + 1} Text: ");
                    answers.Add(new Answer(j + 1, Console.ReadLine()));
                }

                Console.Write("Enter Right Answer ID: ");
                int rightAnswerId ;

                while (!int.TryParse(Console.ReadLine(), out rightAnswerId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid .");
                }


                Questions question = QuestionType == 1 ? new MCQQuestion(body, mark, answers, rightAnswerId) : new TrueOrFalseQuestion(body, mark, answers, rightAnswerId);
               this.Exam.Questions.Add(question);
            }
        }

    }
}
