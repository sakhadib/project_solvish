using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    internal class Exam
    {
        
        
        public int right_ans_ct { get; set; }
        public int wrong_ans_ct { get; set; }
        public int skipped_ct { get; set; }
        public double point { get; set; }
        public int q_count { get; set; }

        public string time { get; set; }

        public Exam()
        {

        }
        public Exam(int right_ans_ct, int wrong_ans_ct, int skipped_ct, double point, int q_count, string time)
        {
            this.right_ans_ct = right_ans_ct;
            this.wrong_ans_ct = wrong_ans_ct;
            this.skipped_ct = skipped_ct;
            this.point = point;
            this.q_count = q_count;
            this.time = time;
        }
    }
}
