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
        public List<Chapter> chapters= new List<Chapter>();
        public List<int> chap_id = new List<int>();
        public int right_ans_ct { get; set; }
        public int wrong_ans_ct { get; set; }
        public int skipped_ct { get; set; }
        public double point { get; set; }
        public int q_count { get; set; }

        public Exam()
        {

        }

        public void add_question(int count, int code)
        {
            
            int[] q_id = Utility.GenerateRandomNumbers(count, code+1, code + 25);
            
            foreach(int qid in q_id)
            {
                Question qq = Utility.getques(qid);
                Questions.Add(qq);
            }
        }

        //call_out
        public void add_chap(Chapter c)
        {
            chapters.Add(c);   
        }
        public void add_chap_id()
        {
            foreach(Chapter c in chapters)
            {
                chap_id.Add(c.Chapter_ID);
            }
        }

        //call_out
        public void load_ques()
        {
            int x = q_count % chapters.Count;
            bool flag = false;
            foreach (int ids in chap_id)
            {
                
                if(x==0)
                {
                    add_question(q_count/chapters.Count, ids);
                }
                else
                {
                    add_question(q_count / chapters.Count, ids);
                    flag = true;
                }

            }
            if(flag)
            {
                add_question(x, chap_id[0]);
            }
        }
    }
}
