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
        //Three Variables to implement timer
        public static int hour { get; set; }
        public static int minute { get; set; }
        public static int second { get; set; }

        //Nessesary list and static data
        public static string username;
        public static List<student> studentsArray = new List<student>();        //master student list
        
        
        //Random Number Generator
        //just call with an int array and it will return the desired value.
        private static Random random = new Random(); // create an instance of the Random class

        public static int[] GenerateRandomNumbers(int count, int min, int max)
        {
            int[] numbers = new int[count]; // create an array to store the random numbers

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(min, max); // generate a random number between min and max
            }

            return numbers;
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
        
    }
}
