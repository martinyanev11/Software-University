using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - Exercise Problem 2/8");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program requires you to enter integer number (your points).");
            Console.WriteLine("After that it will add bonus points following a set of rules.");

            Console.WriteLine("Enter your points:");
            int score = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (score > 1000)
            {
                Console.WriteLine("Your points are more than 1000, you get 10% added bonus.");
                bonus = score + (score * 0.1);
            }
            else if (score > 100)
            {
                Console.WriteLine("Your points are more than 100, you get 20% added bonus.");
                bonus = score + (score * 0.2);
            }
            else if (score <= 100)
            {
                Console.WriteLine("Your points are less than 100 (inclusive), you get 5 bonus points.");
                bonus = score + 5;
            }

            if (score % 2 == 0)
            {
                Console.WriteLine("Your points are an even number, you get 1 bonus point.");
                bonus = bonus + 1;
            }
            else if (score % 10 == 5)
            {
                Console.WriteLine("Your points end with a \"5\", you get 2 bonus points. ");
                bonus = bonus + 2;
            }
            Console.Write("Your bonus points are: ");
            Console.WriteLine(bonus - score);
            Console.Write("Total points: ");
            Console.WriteLine(bonus);
        }
    }
}
