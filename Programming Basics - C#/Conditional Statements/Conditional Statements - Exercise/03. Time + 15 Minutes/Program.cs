using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - Exercise Problem 3/8");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program requires you to enter the time and it will calculate what time it is after 15 minutes.");
            Console.WriteLine("Please enter valid data (0-23 hours and 0-59 minutes).");
            Console.WriteLine();
            Console.WriteLine("Enter hours:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.Write("The time after 15 minutes will be: ");
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
