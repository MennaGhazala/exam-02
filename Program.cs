using System.Diagnostics;

namespace exam_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "C#" );
            subject.CreateExam();
            Console.Clear();
            
            Console.WriteLine(" DO you want to start the exam (y/ n )");
            if (char.Parse(Console.ReadLine())=='y' )
            {Stopwatch sw = Stopwatch.StartNew();
                subject.Exam.SolveExam();
                subject.Exam.ShowExam();

            }
        }
    }
}
