using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int inputTimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputTimes; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(nextNum))
                {
                    numbers.Add(nextNum, 0);
                }
                numbers[nextNum]++;
            }

            foreach (var number in numbers)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
