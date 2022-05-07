using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int listLastIndex = numbersList.Count - 1;
            int listMiddleIndex = numbersList.Count / 2;

            for (int i = 0; i < listMiddleIndex; i++)
            {
                numbersList[i] += numbersList[listLastIndex];
                numbersList.RemoveAt(listLastIndex);
                listLastIndex--;

            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
