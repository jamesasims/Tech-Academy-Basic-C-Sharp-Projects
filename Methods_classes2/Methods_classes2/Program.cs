using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations Math = new MathOperations();
            int value1 = 10;
            int value2 = 20;
            Math.AdditionOperation(5, 7);
            Math.AdditionOperation(value1, value2);
            Console.ReadLine();
        }
    }

}
