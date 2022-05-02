using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPours = int.Parse(Console.ReadLine());
            int sumOfLiters = 0;
            for (int i = 0; i < numberOfPours; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());
                sumOfLiters += litersToPour;
                if (sumOfLiters > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    sumOfLiters -= litersToPour;
                }
            }
            Console.WriteLine(sumOfLiters);
        }
    }
}
