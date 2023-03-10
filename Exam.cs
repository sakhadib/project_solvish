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
        public List<>
        public int right_ans_ct { get; set; }
        public int wrong_ans_ct { get; set; }
        public int skipped_ct { get; set; }
        public double point { get; set; }

        public Exam()
        {

        }

        public void add_question(int code, int count)
        {
            
            int[] q_id = Utility.GenerateRandomNumbers(count, code, code + 25);
            //these question id questions to be called from chapters.
            foreach(int qid in q_id)
            {
                Question qq = Utility.getques(qid);
                Questions.Add(qq);
            }
        }
    }
}
