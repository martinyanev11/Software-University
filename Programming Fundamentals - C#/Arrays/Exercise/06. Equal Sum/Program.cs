using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentIndex = 0;

            foreach (var item in array)
            {
                int sumRightSide = 0;
                int sumLeftSide = 0;
                for (int i = currentIndex + 1; i < array.Length; i++)
                {
                    sumRightSide += array[i];
                }
                for (int j = 0; j < currentIndex; j++)
                {
                    sumLeftSide += array[j];
                }

                if (sumRightSide == sumLeftSide)
                {
                    Console.WriteLine(currentIndex);
                    break;
                }
                if (currentIndex == array.Length - 1)
                {
                    Console.WriteLine("no");
                }
                currentIndex++;
            }
        }
    }
}
