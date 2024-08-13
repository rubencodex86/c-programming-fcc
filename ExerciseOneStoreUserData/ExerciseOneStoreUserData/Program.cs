using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOneStoreUserData
{
    class Program
    {
        
        /*
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line-by-line to the screen
         * Extra: Define variables using the var keyword
         */
        
        static void Main(string[] args)
        {
            string name = "Ruben"; //var name = string
            string phoneNumber = "912367603"; //var phoneNumber = string
            
            /*
             * solution: int number = 0123456789
             * output 123456789
             * to correct this issue:
             * string number = 0123456789
             */
            
            int age = 38; //var age = int

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);
        }
    }
}
