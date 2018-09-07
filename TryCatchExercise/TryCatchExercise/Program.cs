using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to divide the list by: ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                List<int> numberList = new List<int>();
                numberList.Add(10);
                numberList.Add(25);
                numberList.Add(45);
                numberList.Add(64);
                numberList.Add(100);

                foreach (int item in numberList)
                {
                    int answer = item / input1;
                    Console.WriteLine(answer);


                }
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please make sure your format is correct, and enter an integer.");
                
            }
            finally
            {
                Console.WriteLine("Enter a number to divide the list by: ");
                int input1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();

        }
    }
}
