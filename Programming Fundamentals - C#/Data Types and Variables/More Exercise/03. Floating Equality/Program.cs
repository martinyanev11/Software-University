using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());

            decimal biggerNumber = Math.Max(number1, number2);
            decimal smallerNumber = Math.Min(number1, number2);

            decimal sum = biggerNumber - smallerNumber;
            decimal eps = 0.000001M;
            if (sum >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
