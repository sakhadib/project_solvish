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

    }
}
