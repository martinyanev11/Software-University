using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            HashSet<int> firstSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> mergedRepeatingInts = new HashSet<int>();
            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    mergedRepeatingInts.Add(num);
                }
            }
            foreach (var num in mergedRepeatingInts)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
