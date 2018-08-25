using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to multiply it by 50: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            int total = number1 * 50;
            Console.Write("Now the number is " + total + "\nNow enter a number to add 25 to it: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            int total2 = number2 + 25;
            Console.Write("Now the number is " + total2 + "\nNow input a number to divide by 12.5: ");
            string input3 = Console.ReadLine();
            int number3 = Convert.ToInt32(input3);
            double help1 = 12.5;
            double total3 = number3 / help1;
            Console.Write("Now your number is " + total3 + "\nNow input a number to check if it is great than 50: ");
            string input4 = Console.ReadLine();
            int number4 = Convert.ToInt32(input4);
            bool total4 = number4 > 50;
            Console.WriteLine(total4);
            Console.WriteLine("Now input a number to divide by 7 and recieve the remainder: ");
            string input5 = Console.ReadLine();
            int number5 = Convert.ToInt32(input5);
            double total5 = number5 / 7;
            double remainder = number5 % 7;
            Console.WriteLine("Your answer is: " + total5 + "\nWith a remainder of: " + remainder);





            Console.ReadLine();
            

        }
    }
}
