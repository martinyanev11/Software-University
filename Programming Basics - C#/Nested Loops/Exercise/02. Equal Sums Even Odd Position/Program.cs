using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= endNumber; i++)
            {
                int evenSum = 0;
                int oddSum = 0;

                int delimeter = 10;
                int currentNumber = i;

                for (int j = 1; j <= 6; j++) // 6 - because we know we have numbers with 6 digits.
                {
                    int currentLastDigit = currentNumber % delimeter;
                    currentNumber /= delimeter;

                    if (j % 2 == 0)
                    {
                        evenSum += currentLastDigit;
                    }
                    else
                    {
                        oddSum += currentLastDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
