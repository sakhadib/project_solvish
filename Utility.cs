using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Solvish
{
    static class Utility
    {
        //creating forms
        //public static dashboard de = new dashboard();
        
        //Three Variables to implement timer
        public static int hour { get; set; }
        public static int minute { get; set; }
        public static int second { get; set; }

        //Nessesary list and static data
        //public static string username;
        public static List<student> studentsArray = new List<student>();        //master student list
        public static List<Exam> ExamsArray = new List<Exam>();

        public static student current_student;

        public static int total_corr;
        public static int total_wrong;
        public static int total_skip;
        public static double total_point;

        
        
        
        //Random Number Generator
        //just call with an int array and it will return the desired value.
        private static Random random = new Random(); // create an instance of the Random class

        public static int[] GenerateRandomNumbers(int count, int min, int max)
        {
            if (count > (max - min + 1))
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than the range between min and max.");
            }

            Random random = new Random();
            HashSet<int> generatedNumbers = new HashSet<int>();
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                int nextNumber;
                do
                {
                    nextNumber = random.Next(min, max + 1);
                } while (generatedNumbers.Contains(nextNumber));

                generatedNumbers.Add(nextNumber);
                result[i] = nextNumber;
            }

            return result;
        }

        //master question list
        public static List<Question> QuestionsArray = new List<Question>();
        public static Question qq;
        //return question from master list
        public static Question getques(int id)
        {
            foreach (Question question in QuestionsArray)
            {
                if(question.id == id)
                {
                    qq = question;
                }
            }
            return qq;
        }

        //initializer methods
        // in start button. it is implimented
        
        

        //Other Necessary Functions
        public static void count_result()
        {
            Utility.total_corr = 0;
            Utility.total_wrong = 0;
            Utility.total_skip = 0;
            Utility.total_point = 0;

            foreach (Exam exam in Utility.ExamsArray)
            {
                Utility.total_corr += exam.right_ans_ct;
                Utility.total_wrong += exam.wrong_ans_ct;
                Utility.total_skip += exam.skipped_ct;
                Utility.total_point += exam.point;
            }
        }
        
    }
}
