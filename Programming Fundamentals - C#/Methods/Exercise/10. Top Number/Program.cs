using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());

            for (int i = 0; i <= endValue; i++)
            {
                if (DigitSum(i) == true && HoldsOddDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool DigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += Math.Abs(number % 10);
                number /= 10;
            }
            bool isSubtractedByEight = false;
            if (sum % 8 == 0)
            {
                isSubtractedByEight = true;
            }
            return isSubtractedByEight;
        }

        static bool HoldsOddDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
