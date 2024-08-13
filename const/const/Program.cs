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
            // to stop variable property
            const int vat = 20;

            //vat = 10;


            int balance = 1000;

            Console.WriteLine(balance * (vat/100D));

            const double percentVAT = vat / 100D;
            Console.WriteLine(balance * percentVAT);
            
            const string version = "v1.0";
            
        }
    }
}