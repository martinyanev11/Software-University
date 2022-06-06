using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parser = n => int.Parse(n);
            int[] numbers = input.Split(", ").Select(parser).ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
