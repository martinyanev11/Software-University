using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            SortedDictionary<char, int> repetitions = new SortedDictionary<char, int>();

            for (int ch = 0; ch < sentence.Length; ch++)
            {
                if (!repetitions.ContainsKey(sentence[ch]))
                {
                    repetitions.Add(sentence[ch], 0);
                }
                repetitions[sentence[ch]]++;
            }

            foreach (var ch in repetitions)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
