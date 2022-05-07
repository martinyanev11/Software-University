using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersList = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] == numbersList[i + 1])
                {
                    numbersList[i] += numbersList[i + 1];
                    numbersList.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbersList));

        }
    }
}
