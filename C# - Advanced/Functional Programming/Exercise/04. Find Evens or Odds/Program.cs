using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerBound = input[0];
            int upperBound = input[1];
            string command = Console.ReadLine();

            Predicate<int> evenFilter = x => x % 2 == 0; // even
            Predicate<int> oddFilter = x => x % 2 != 0; // odd

            List<int> filteredNumbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if ((command == "even") && evenFilter(i))
                {
                    filteredNumbers.Add(i);
                }
                else if ((command == "odd") && oddFilter(i))
                {
                    filteredNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}
