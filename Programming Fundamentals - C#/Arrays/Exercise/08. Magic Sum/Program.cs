using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int currentIndex = 0;

            foreach (var item in array)
            {
                for (int i = currentIndex; i < array.Length; i++)
                {
                    if (i != currentIndex)
                    {
                        if (item + array[i] == number)
                        {
                            Console.WriteLine($"{item} {array[i]}");
                        }
                    }
                }
                currentIndex++;
            }
        }
    }
}
