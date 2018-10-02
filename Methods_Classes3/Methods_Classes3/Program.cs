using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation Math = new MathOperation();


            Console.WriteLine(Math.IntOperation(12));
            Console.WriteLine(Math.IntOperation(10.6m));
            Console.WriteLine(Math.IntOperation("lol"));
            Console.ReadLine();

        }
    }

}
