using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[] { "Strawberry", "BlueBerry", "Mango", "Raspberry" };
            Console.WriteLine("Enter a number between 0-3 to see which fruit you picked: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 > 3)
            {
                Console.WriteLine("You must pick a number between 0 and 3, try again: ");
                input1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have picked a " + fruit[input1]);


            int[] numbers = new int[] { 11, 22, 33, 44, 55, 66, 77, 88 };
            Console.WriteLine("Now enter a number between 0-7 for a random number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 > 7)
            {
                Console.WriteLine("You must pick a number between 0 and 7, try again: ");
                input2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The number you picked is " + numbers[input2]);

            List<string> names = new List<string>();
            names.Add("James");
            names.Add("Alex");
            names.Add("Jimmy");
            names.Add("Sims");

            Console.WriteLine("Now pick a number between 0-3 to see one of my nicknames: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 > 3)
            {
                Console.WriteLine("You must pick a number between 0 and 3, try again: ");
                input3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("One of my nicknames was " + names[input3]);

            Console.ReadLine();


        }
    }
}
