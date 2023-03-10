using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvish
{
    class Utility
    {
        //Random Number Generator
        //just call with an int array and it will return the desired value.
        private Random random = new Random(); // create an instance of the Random class

        public int[] GenerateRandomNumbers(int count, int min, int max)
        {
            int[] numbers = new int[count]; // create an array to store the random numbers

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(min, max); // generate a random number between min and max
            }

            return numbers;
        }


        //Other Necessary Functions

    }
}
