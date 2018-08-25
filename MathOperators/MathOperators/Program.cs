using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n Person #1:");
            Console.WriteLine("Person #1, please enter your hourly rate: ");
            string per1input1 = Console.ReadLine();
            Console.WriteLine("Person #1, please enter your hours worked per week: ");
            string per1input2 = Console.ReadLine();
            Console.WriteLine(" Person #2:\nPerson #2, please enter your hourly rate: ");
            string per2input1 = Console.ReadLine();
            Console.WriteLine("Person #2, please enter you hours worked per week: ");
            string per2input2 = Console.ReadLine();
            decimal per1hourly = Convert.ToDecimal(per1input1);
            decimal per1hoursperweek = Convert.ToDecimal(per1input2);
            decimal per1annual = (per1hourly * per1hoursperweek)*52;
            decimal per2hourly = Convert.ToDecimal(per2input1);
            decimal per2hoursperweek = Convert.ToDecimal(per2input2);
            decimal per2annual = (per2hourly * per2hoursperweek) * 52;
            bool compare = per1annual > per2annual;
            Console.Write("Annual Salary of Person #1: $" + per1annual + "\nAnnual Salary of Person #2: $" + per2annual + "\nDoes Person #1 make more money than Person #2? " + compare);




            Console.ReadLine();
            
        }
    }
}
