using System;
using System.Collections.Generic;
using System.Linq;

namespace Swap
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int indexOne = indexes[0];
            int indexTwo = indexes[1];

            var box = new Box<string>(list);
            box.Swap(list, indexOne, indexTwo);
            Console.WriteLine(box);
        }
    }
}
