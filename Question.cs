using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    internal class Question
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public Enum_for_right_answer Right_Answer { get; set; }
        public Question(string title, string description, string answer1, string answer2, string answer3, Enum_for_right_answer right_Answer)
        {
            Title = title;
            Description = description;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Right_Answer = right_Answer;
        }
    }
}
