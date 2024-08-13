using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOddEvenChecker
{
    class Program
    {
        /*
         * Create & initialise two ints
         * Make a variable to work out the remainder
         * Output remainder to the screen
         * Change the first int variable to another number
            * and recalculate the remainder
            * output new remainder to the screen
         */
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 2;
            var remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            numOne = 101;
            remainder = numOne % numTwo;
            Console.WriteLine(remainder);
        }
    }
}