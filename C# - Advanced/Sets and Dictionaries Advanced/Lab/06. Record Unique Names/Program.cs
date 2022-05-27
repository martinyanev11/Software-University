using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < inputCount; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }

            for (int i = 0; i < set.Count; i++)
            {
                Console.WriteLine(set.ElementAt(i));
            }
        }
    }
}
