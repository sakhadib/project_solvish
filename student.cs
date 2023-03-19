using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Solvish
{
    internal class student
    {
        List<Exam> exams = new List<Exam>();
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public int totalRight { get; set; }
        public int totalWrong { get; set; }
        public int totalSkipped { get; set; }
        public double totalPoint { get; set; }

        public student(string name, string username, string password)
        {

            this.name = name;
            this.username = username;
            this.password = password;
        }

        public void addexam(Exam e)
        {
            totalRight += e.right_ans_ct;
            totalWrong += e.wrong_ans_ct;
            totalPoint += e.point;
            exams.Add(e);
        }
    }
}
