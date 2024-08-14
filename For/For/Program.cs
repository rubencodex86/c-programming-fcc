using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi!");
            }

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.Write("What message do you want to repeat?: ");
            string message = Console.ReadLine();
            
            Console.Write("How many times do you want to repeat?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0 || message=="")
            {
                Console.WriteLine("Sorry, please enter a value above 0 or a proper message");
            }
            else
            {
                for (int i = 1; i <= loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}

