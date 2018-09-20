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
            int input = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(MathOperations.AdditionOperation(MathOperations.answer, MathOperations.answer));
            
           
            Console.ReadLine();



        }
    }
}
