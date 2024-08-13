using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            age++;
            age = age + 10;
            //+ - * /
            age += 10; //same as previous line
            
            /*for making division we should use double instead of int because with int the output of 23/10 will be 2
            instead of 2.3*/
            
            //Console.WriteLine(age);
            age--;
            //Console.WriteLine(age);
            
            //what happens using strings
            string name = "Aba";
            name += " is programming!";
            //name -= " is programming!"; //does not work
            
            /*
                with char it doesn't work properly
                char ch = 'a';
                ch += b;
                Console.WriteLine(ch); //output Ã
            */
            
            //Console.WriteLine(name);

            int i = 0;
            // i++ vs ++i vs CW(i++)
            //i++;
            //Console.WriteLine(++i);
            
            //---------------------------------------------------------------------------------------------------------
            //Remainder (%)
            
            //good to determine if number is even or odd

            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum / secondNum); //output 2
            Console.WriteLine(firstNum % secondNum); //output 1
            
            //10 % 2 = 0
            //11 % 2 = 1
            //12 % 2 = 0
        }
    }
}