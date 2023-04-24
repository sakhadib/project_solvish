using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    internal class Question
    {
        public int id { get; set; }
        public string statement { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }
        public string givenans { get; set; }

        public Question(int id, string statement, string option1, string option2, string option3, string option4, string correctAnswer)
        {
            this.id = id;
            this.statement = statement;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            CorrectAnswer = correctAnswer;
        }

        public Question(string statement, string option1, string option2, string option3, string option4, string correctAnswer, string givenAnswer)
        {
            
            this.statement = statement;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            CorrectAnswer = correctAnswer;
            givenans = givenAnswer;
        }
    }
}
