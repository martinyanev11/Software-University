using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsUpperCase = x => char.IsUpper(x[0]);
            string[] sentence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => startsUpperCase(x)).ToArray();
            foreach (var word in sentence)
            {
                Console.WriteLine(word);
            }
        }
    }
}
