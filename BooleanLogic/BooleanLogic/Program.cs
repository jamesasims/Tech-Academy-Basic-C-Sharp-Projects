﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string input1 = Console.ReadLine();
            int age = Convert.ToInt32(input1);
            Console.WriteLine("Have you ever had a DUI? (Please answer yes or no)");
            string input2 = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string input3 = Console.ReadLine();
            int tickets = Convert.ToInt32(input3);
            Console.WriteLine("Qualified?");
            bool qualified = (age >= 15) && (input2 == "no") && (tickets <= 3);
            Console.WriteLine(qualified);

            Console.ReadLine();
            


        }
    }
}
