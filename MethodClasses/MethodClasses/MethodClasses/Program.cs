using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClasses
{
    public class Program : MathOperations
    {

        public static MathOperations MathOperations { get; set; }
       

        public static void Main(string[] args)
        {
            MathOperations = new MathOperations();
            Console.WriteLine("Please provide a number: ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Your number plus twenty six equals: " + MathOperations.AdditionOperation(userinput, MathOperations.answer));
            Console.WriteLine("Your number multiplied by five equals: " + MathOperations.MultiplicationOperation(userinput, MathOperations.answer2));
            Console.WriteLine("Your number subtraced by four equals: " + MathOperations.SubtractionOperation(userinput, MathOperations.answer3));

            Console.ReadLine();



        }
    }
}
