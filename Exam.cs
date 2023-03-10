using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    internal class Exam
    {
        public List<Question> Questions = new List<Question>();
        public int right_ans_ct { get; set; }
        public int wrong_ans_ct { get; set; }
        public int skipped_ct { get; set; }
        public double point { get; set; }

        public Exam()
        {

        }

        public void add_question(int code, int count)
        {

        }
    }
}
