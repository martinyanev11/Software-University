using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = new string(Console.ReadLine()).Split();
            int[] intArr = new int[stringArr.Length];

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < stringArr.Length; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);
                if (intArr[i] % 2 == 0)
                {
                    sumEven += intArr[i];
                }
                else
                {
                    sumOdd += intArr[i];
                }
            }
            Console.WriteLine($"{ sumEven - sumOdd}");
        }
    }
}
