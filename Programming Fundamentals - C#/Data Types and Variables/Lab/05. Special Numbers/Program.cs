using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int digitSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                while (currentNumber != 0)
                {
                    lastDigit = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    digitSum += lastDigit;
                }

                bool isSpecial = digitSum == 5 || digitSum == 7 || digitSum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
                digitSum = 0;
            }

        }
    }
}
