using System;

namespace _06._Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - LAB Problem 6/7");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program requires you to enter your speed (number) and it will tell you how fast you are.");
            Console.WriteLine("Please enter speed:");
            double speed = double.Parse(Console.ReadLine());

            Console.Write("You are ");
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
