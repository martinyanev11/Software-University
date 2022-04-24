using System;

namespace _04._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - LAB Problem 4/7");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program checks weather you entered the password \"s3cr3t!P@ssw0rd\"");
            Console.WriteLine("Please enter password:");
            string userInputPW = Console.ReadLine();

            string pw = "s3cr3t!P@ssw0rd";

            if (userInputPW == pw)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
