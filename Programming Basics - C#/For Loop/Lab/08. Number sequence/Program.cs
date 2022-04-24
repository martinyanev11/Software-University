using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int userNumbers = int.Parse(Console.ReadLine());

                if (userNumbers > maxNumber)
                {
                    maxNumber = userNumbers;
                }
                if (userNumbers < minNumber)
                {
                    minNumber = userNumbers;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
