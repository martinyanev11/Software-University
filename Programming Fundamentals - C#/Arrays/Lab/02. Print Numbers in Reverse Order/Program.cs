using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] integers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                integers[i] = integer;
            }

            for (int j = n - 1; j >= 0; j--)
            {
                Console.Write($"{integers[j]} ");
            }
        }
    }
}
