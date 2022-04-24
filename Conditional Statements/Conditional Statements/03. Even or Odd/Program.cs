using System;

namespace _03._Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - LAB Problem 3/7");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program requires you to enter an integer and it will tell weather it is even or odd.");
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Checking weather it is even or odd
            int check = number % 2;

            Console.Write("The number is: ");
            if (check == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
