using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int startingOddNumber = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(startingOddNumber);
                sum += startingOddNumber;
                startingOddNumber += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
