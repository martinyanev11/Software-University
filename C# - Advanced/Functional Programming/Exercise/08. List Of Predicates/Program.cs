using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());

            List<int> listToFilter = new List<int>();
            for (int i = 1; i <= endRange; i++)
            {
                listToFilter.Add(i);
            }

            int[] filters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queueFilters = new Queue<int>(filters);
            while (queueFilters.Count != 0)
            {
                int nextPredicateNum = queueFilters.Dequeue();
                Predicate<int> predicate = x => x % nextPredicateNum != 0;

                listToFilter.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", listToFilter));
        }
    }
}
