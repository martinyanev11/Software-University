using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;

            foreach (int item in array)
            {
                bool isTopInteger = false;
                for (int i = counter; i < array.Length; i++)
                {
                    if (item < array[i])
                    {
                        break;
                    }
                    if (i == array.Length - 1)
                    {
                        isTopInteger = true;
                    }
                }
                if (isTopInteger == true)
                {
                    Console.Write(item + " ");
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}
