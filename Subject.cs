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
           
        }
        

        public void CreateExam()
        {



            Console.Write("Enter Exam Type (1: Final, 2: Practical): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Time (minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            Exam exam = examType == 1 ? new FinalExam(time, numQuestions) : new PracticalExam(time, numQuestions);
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write("Enter Exam Type (1: mcq , 2: True or Flase): ");
                int QuestionType = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                Console.Write("Enter Number of Answers: ");
                int numAnswers = int.Parse(Console.ReadLine());

                List<Answer> answers = new List<Answer>();
                for (int j = 0; j < numAnswers; j++)
                {
                    Console.Write($"Enter Answer {j + 1} Text: ");
                    answers.Add(new Answer(j + 1, Console.ReadLine()));
                }

                Console.Write("Enter Right Answer ID: ");
                int rightAnswerId = int.Parse(Console.ReadLine());



                Questions question = QuestionType == 1 ? new MCQQuestion(body, mark, answers, rightAnswerId) : new TrueOrFalseQuestion(body, mark, answers, rightAnswerId);
                exam.Questions.Add(question);
            }
        }

    }
}
