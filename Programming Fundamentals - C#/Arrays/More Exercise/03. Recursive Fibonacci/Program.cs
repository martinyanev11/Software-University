using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] fibonacciArray = new long[50];

            fibonacciArray[0] = 1;
            fibonacciArray[1] = 1;

            for (int i = 2; i < fibonacciArray.Length; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }

            int fibonacciIndexToPrint = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacciArray[fibonacciIndexToPrint - 1]);
        }
    }
}
