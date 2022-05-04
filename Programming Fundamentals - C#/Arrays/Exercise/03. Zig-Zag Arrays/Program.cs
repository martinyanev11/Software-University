using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            int firstIndex = 0;
            int secondIndex = 1;

            for (int i = 0; i < n; i++)
            {
                int[] tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = tempArray[firstIndex];
                    secondArray[i] = tempArray[secondIndex];
                }
                else
                {
                    firstArray[i] = tempArray[secondIndex];
                    secondArray[i] = tempArray[firstIndex];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
