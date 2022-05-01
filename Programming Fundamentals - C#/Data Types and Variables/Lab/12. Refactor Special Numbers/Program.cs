using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                int digitSum = 0;
                while (i > 0)
                {
                    digitSum += i % 10;
                    i = i / 10;
                }
                bool isSpecialNumber = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNumber);
                i = currentNumber;
            }

        }
    }
}
