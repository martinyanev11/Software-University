using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            double[] numbersVAT = numbers.Select(x => x + x * 0.2).ToArray();
            foreach (var num in numbersVAT)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
