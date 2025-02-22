using System.Diagnostics;
using exam_02;
namespace exam_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer answer = new Answer(1, "This is an answer");
            Subject subject = new Subject(10, "C#" );
            subject.CreateExam();
            Console.Clear();
            if (subject.Exam == null)
            {
                Console.WriteLine("Error: Exam is NULL! Make sure to create an exam.");
                return;
            }

            Console.WriteLine(" DO you want to start the exam (y/ n )");
            
            if (char.Parse(Console.ReadLine())=='y' )
            {
               subject.Exam.SolveExam();
                subject.Exam.ShowResultExam();

            }
        }
    }
}
