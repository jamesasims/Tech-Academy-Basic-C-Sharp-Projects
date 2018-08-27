using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "James";
            string mname = " Alexander";
            string lname = " Sims";
            Console.WriteLine("My full name is " + fname + mname + lname + "\nPress enter to turn \"hello\" into uppercase");
            Console.ReadLine();
            string hello = "hello";
            string upper = hello.ToUpper();
            Console.WriteLine(upper);
            StringBuilder firstStringBuilder = new StringBuilder("This is my first time using the StringBuilder Class.");
            firstStringBuilder.Append(" And this is my first sentence I've appended to the StringBuilder.");
            firstStringBuilder.Append(" I am starting to understand how this can be a very useful tool for string creation.");
            firstStringBuilder.Append(" Hopefully this turns out like a paragraph!");

            Console.WriteLine(firstStringBuilder);


            Console.ReadLine();
            

        }
    }
}
