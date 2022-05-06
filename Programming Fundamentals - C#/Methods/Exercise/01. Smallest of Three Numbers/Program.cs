using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = int.MaxValue;
            Console.WriteLine(SmallestNumber(smallestNumber));
        }

        static int SmallestNumber(int smallestNumber)
        {
            for (int i = 0; i < 3; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }
            return smallestNumber;
        }
    }
}
