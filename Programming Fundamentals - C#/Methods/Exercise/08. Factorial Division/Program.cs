using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger number1 = int.Parse(Console.ReadLine());
            BigInteger number2 = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(number1) / Factorial(number2);
            Console.WriteLine($"{result:f2}");
        }

        static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorialCalculationResult = 1;

            for (int i = (int)number; i > 1; i--)
            {
                factorialCalculationResult *= i;
            }
            return factorialCalculationResult;
        }
    }
}
