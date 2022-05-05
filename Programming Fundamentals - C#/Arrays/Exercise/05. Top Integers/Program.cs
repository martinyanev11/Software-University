using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;

            foreach (int number in array)
            {
                bool isTopInteger = false;
                for (int i = counter; i < array.Length; i++)
                {
                    if (number <= array[i])
                    {
                        break;
                    }
                    if (i == array.Length - 1)
                    {
                        isTopInteger = true;
                    }
                }
                if (counter == array.Length)
                {
                    isTopInteger = true;
                }
                if (isTopInteger == true)
                {
                    Console.Write(number + " ");
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}
