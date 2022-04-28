using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            // SUMS ALL FACTORIALS
            long factorialSum = 0;

            for (int i = 0; i < number.Length; i++)
            {

                char currentChar = number[i];
                int currentDigit = (int)currentChar - 48;

                long currentDigitFactorial = 1;
                for (int r = currentDigit; r > 1; r--)
                {
                    currentDigitFactorial *= r;
                }

                factorialSum += currentDigitFactorial;
            }

            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
