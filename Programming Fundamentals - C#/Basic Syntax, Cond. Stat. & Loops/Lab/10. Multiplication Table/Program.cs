using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                multiplier += 1;
            }
        }
    }
}
