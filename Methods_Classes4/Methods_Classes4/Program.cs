using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes4
{
    class Program
    {
        static void Main(string[] args)
        {

            MathOperations Math = new MathOperations();
            Console.WriteLine("Please enter a the first number: ");
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number is optional, enter  here: ");
            string userinput2 = Console.ReadLine();
            if(String.IsNullOrEmpty(userinput2))
            {
                int userinput3 = 0;
                
                Console.WriteLine("Your number multiplied by nothing equals: " + Math.MultiplicationMethod(userinput1, userinput3));
            }
            else
            {
                int userinput4 = Convert.ToInt32(userinput2);
                Console.WriteLine("Your two numbers multiplied by each other is: " + Math.MultiplicationMethod(userinput1, userinput4));
            }
           
            
            
            Console.ReadLine();



        }
    }
}
