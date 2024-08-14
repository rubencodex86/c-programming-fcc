using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();
            
            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;
            int actualAnswer = 0; //video solution
            
            Console.Write("Value of " + numberA + " x " + numberB+ ": ");
            //int actualAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); //video solution
            
            while (actualAnswer != answer)
            {
                // Console.WriteLine("Close but it was wrong!");
                // Console.Write("Value of " + numberA + " x " + numberB+ ": ");
                // actualAnswer = Convert.ToInt32(Console.ReadLine());
                
                //video solution
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());
                
                if (actualAnswer != answer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Well done!");
            
            // do while loop

            do
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (actualAnswer != answer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            } while (actualAnswer != answer);
            Console.WriteLine("Well done!");
        }
    }
}