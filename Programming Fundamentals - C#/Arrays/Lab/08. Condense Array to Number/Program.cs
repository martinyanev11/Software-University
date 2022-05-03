using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = numbers.Length;

            while (counter > 1)
            {
                int[] newArr = new int[counter - 1];
                for (int i = 0; i < counter - 1; i++)
                {
                    newArr[i] = numbers[i] + numbers[i + 1];
                }
                counter--;
                numbers = newArr;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
