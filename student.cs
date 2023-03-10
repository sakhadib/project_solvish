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
        public string fname { get; set; }
        public string lname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string school { get; set; }
        public string cclass { get; set; } // as class is not a usable variable

        public string password { get; set; }

        public int totalRight { get; set; }
        public int totalWrong { get; set; }
        public double totalPoint { get; set; }

        public student (string fname, string lname, string phone, string email, string school, string cclass, string password)
        {
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.school = school;
            this.cclass = cclass;
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
