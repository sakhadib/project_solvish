using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    internal static class utility2
    {
        public static List<int> current_exam_chaps = new List<int>();
        public static List<Question> current_questions = new List<Question>();
        public static int num_of_ques;

        //hisab nikas
        public static int rt_ans;
        public static int wr_ans;
        public static int sk_ans;
        public static double curr_point;

        //hisab nikash back to zero
        public static void re_init()
        {
            Utility.current_student.totalRight += rt_ans;   rt_ans = 0;
            Utility.current_student.totalWrong += wr_ans;   wr_ans = 0;
            Utility.current_student.totalSkipped += sk_ans; sk_ans = 0;
            Utility.current_student.totalPoint += curr_point; curr_point = 0;
        }


        //get questions from master list to this list to be appear on exam.
        public static void init_ques()
        {
            int count = current_exam_chaps.Count();
            int perchap = num_of_ques/ count;
            int rem = num_of_ques % count;

            foreach(int c in current_exam_chaps)
            {
                int[] quesids = Utility.GenerateRandomNumbers(perchap,c+1,c+20);
                foreach(int s in quesids)
                {
                    Question q = Utility.getques(s);
                    current_questions.Add(q);
                }
            }
            if(rem != 0)
            {
                int c = current_exam_chaps[0];
                int[] againquesid = Utility.GenerateRandomNumbers(rem, c + 1, c + 20);
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
