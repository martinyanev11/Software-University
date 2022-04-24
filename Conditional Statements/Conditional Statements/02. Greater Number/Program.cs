using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - LAB Problem 2/7");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program requires you to enter two integers and it will print the bigger one.");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The bigger one is:");
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else Console.WriteLine(num2);
        }
    }
}
