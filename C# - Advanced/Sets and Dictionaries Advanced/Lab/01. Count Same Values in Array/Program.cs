using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> occurances = new Dictionary<double, int>();

            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (!occurances.ContainsKey(array[i]))
                {
                    occurances.Add(array[i], 0);
                }
                occurances[array[i]]++;
            }

            foreach (var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
