using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            // Write on console the first name with symbols (ASCII) sum >= to the given number
            // Console.WriteLine(names.Find(name => name.Select(symbol => (int)symbol).Sum() >= number));

            Func<string, bool> charSumFunc = name =>
            {
                char[] array = name.ToCharArray();
                int sum = 0;
                foreach (char ch in array)
                {
                    sum += ch;
                }
                if (sum >= number)
                {
                    return true;
                }
                return false;
            };

            foreach (string name in names)
            {
                if (charSumFunc(name))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}
