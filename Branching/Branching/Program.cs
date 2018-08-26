using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below.\nPlease enter the weight of the package (lbs)");
            int weight = Convert.ToInt32(Console.ReadLine());
            if(weight>50)
            {
                Console.WriteLine("Package is to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Now please enter the package height in inches:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please enter the package length in inches:");
            int length = Convert.ToInt32(Console.ReadLine());
            if ((height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double price = ((height + length) * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + price);


            Console.ReadLine();
        }
    }
}
