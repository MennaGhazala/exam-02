using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    public abstract class Questions
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public List <Answer> Answers{ get; set; }

        public int UserAnswer { get; set; }
        public int  RightAnswer { get; set; }
        public Questions(string header, string body , int mark ) { 
            Header = header;
            Body = body;
            Mark = mark;
        
        }

        public abstract void ShowQuestion();
    }
}
