﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is Aba!");
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);
            
            Console.Write("Enter your age: ");
            //--------------------------------------------
            // string ageInput = Console.ReadLine();
            // int age = Convert.ToInt32(ageInput);
            
            //or 

            int age = Convert.ToInt32(Console.ReadLine());
            
            //--------------------------------------------
            
            //Console.WriteLine(age);
            
            // Console.Write("Your name is ");
            // Console.Write(name);
            // Console.Write(" and your age is ");
            // Console.Write(age);

            Console.WriteLine();
            
            //Concatenate text
            Console.WriteLine("Your name is " + name + " and your age is " + age);
        }
    }
}