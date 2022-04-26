using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            int primeSum = 0;
            int nonPrimeSum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                int delimiterCounter = 0; // This count how many times a number is divided

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        delimiterCounter++;
                    }
                }

                if (delimiterCounter == 2) // => Number is prime
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
