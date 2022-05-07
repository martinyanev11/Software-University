using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int secondCounter = 0;
            if (list1.Count >= list2.Count)
            {
                for (int i = 1; i < list2.Count * 2; i += 2)
                {
                    list1.Insert(i, list2[secondCounter]);
                    secondCounter++;
                }
                Console.WriteLine(string.Join(" ", list1));
            }
            else
            {
                for (int i = 0; i < list1.Count * 2; i += 2)
                {
                    list2.Insert(i, list1[secondCounter]);
                    secondCounter++;
                }
                Console.WriteLine(string.Join(" ", list2));
            }
        }
    }
}
