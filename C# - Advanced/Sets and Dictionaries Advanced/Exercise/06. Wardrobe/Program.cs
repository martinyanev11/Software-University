using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int inputLines = int.Parse(Console.ReadLine());

            InputDataCollection(wardrobe, inputLines);

            DictionaryPrinting(wardrobe);
        }

        private static void InputDataCollection(Dictionary<string, Dictionary<string, int>> wardrobe, int inputLines)
        {
            for (int i = 0; i < inputLines; i++)
            {

                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string clothing in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothing))
                    {
                        wardrobe[color].Add(clothing, 0);
                    }
                    wardrobe[color][clothing]++;
                }
            }
        }

        private static void DictionaryPrinting(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] searchData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorToSearch = searchData[0];
            string clothesToSearch = searchData[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothing in color.Value)
                {
                    if (color.Key == colorToSearch && clothing.Key == clothesToSearch)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                    
                }
            }
        }
    }
}
