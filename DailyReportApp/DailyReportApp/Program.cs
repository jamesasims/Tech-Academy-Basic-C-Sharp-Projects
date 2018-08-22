using System;


namespace DailyReportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat course are you on?");
            string courseansw = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageansw = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please Answer True or False.");
            string helpansw = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiencesansw = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackansw = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursansw = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\nHave a great day!");

            Console.ReadLine();
            
        }
    }
}
