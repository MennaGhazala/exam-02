using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public class TrueOrFalseQuestion :Questions
    {
        public TrueOrFalseQuestion( string body, int mark,List< Answer >answers, int rightAnswer)
         : base("Choose True or False", body, mark)
        {
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer);
            }

        }  
    }
}
