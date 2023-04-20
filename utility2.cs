using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvish
{
    internal static class utility2
    {
        public static List<int> current_exam_chaps = new List<int>();
        public static List<Question> current_questions = new List<Question>();
        public static int num_of_ques;
        public static Exam current_exam = new Exam();

        public static int examcount = 1;  //To add every exam to the graph

        

        //hisab nikas
        public static int rt_ans = 0;
        public static int wr_ans = 0;
        public static int sk_ans = 0 ;
        public static double curr_point = 0;

        //hisab nikash back to zero
        public static void re_init()
        {
            string format = "dd/MM/yyyy hh:mm:ss";
            string v = DateTime.Now.ToString(format);
            current_exam.time = v;
            current_exam.right_ans_ct = rt_ans;
            current_exam.wrong_ans_ct = wr_ans;
            current_exam.skipped_ct = sk_ans;
            current_exam.point = curr_point;
            current_exam.q_count = num_of_ques;

            Exam ee = new Exam();
            ee.time = DateTime.Now.ToString();
            ee.right_ans_ct = rt_ans;
            ee.wrong_ans_ct = wr_ans;
            ee.skipped_ct = sk_ans;
            ee.point = curr_point;
            ee.q_count = num_of_ques;

            Utility.ExamsArray.Add(ee);



            Utility.current_student.totalRight += rt_ans;   
            rt_ans = 0;
            Utility.current_student.totalWrong += wr_ans;   
            wr_ans = 0;
            Utility.current_student.totalSkipped += sk_ans; 
            sk_ans = 0;
            Utility.current_student.totalPoint += curr_point; 
            curr_point = 0;

            
        }


        //get questions from master list to this list to be appear on exam.
        public static void init_ques()
        {
            utility2.current_questions.Clear();
            int chapter_count = current_exam_chaps.Count();
            int perchap = num_of_ques/ chapter_count;
            int rem = num_of_ques % chapter_count;

            for(int i=0; i<chapter_count; i++)
            {
                int[] quesids = Utility.GenerateRandomNumbers(perchap, current_exam_chaps[i] + 1, current_exam_chaps[i] + 20);
                foreach(int id in quesids)
                {
                    foreach(Question q in Utility.QuestionsArray)
                    {
                        if(q.id == id)
                        {
                            utility2.current_questions.Add(q);
                            break;
                        }
                    }
                    
                }
            }

            
            //making the question list random so it wont look like its in serial in chapter.
            ShuffleQuestions(current_questions);
            
        }



        public static void ShuffleQuestions(List<Question> current_quest)
        {
            // Create a new instance of the Random class
            Random rng = new Random();

            // Use the List<T>.Sort method with a custom comparison function that
            // compares two elements randomly using the Random class
            current_questions.Sort((a, b) => rng.Next(2) == 0 ? -1 : 1);
        }
    }
    
}
