using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - Exercise Problem 1/8");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program calculates how much time 3 racers need to finish.");
            Console.WriteLine("You are required to enter the time for each in seconds (1-50)");

            Console.WriteLine("Enter time for 1st racer:");
            int firstTime = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time for 2nd racer:");
            int secondTime = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time for 3rd racer:");
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            Console.Write("The time they need to finish the race is: ");
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
