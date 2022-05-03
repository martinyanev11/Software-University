using System;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentNum = int.Parse(firstArray[i]);

                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    currentNum = int.Parse(firstArray[i]);
                    sum += currentNum;
                }
                if (i == firstArray.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }

            }
        }
    }
}
