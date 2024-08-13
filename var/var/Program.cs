using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // the compiler will figure out what type it needs to based on the value initialized
            // only use var when its very obvious ex... ages.
            var age = 23;
            //int age = -23;
            Console.WriteLine(age);

            var bigNumber = 900000000L;
            //long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);

            var negative = -55.3;
            //double negative = -55.3D;
            Console.WriteLine(negative);
 
            var precision = 5.000001F;
            //float precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            //decimal money = 14.99M;
            Console.WriteLine(money);

            var name = "Aba"; 
            var letter = 'a';
        }
    }
}