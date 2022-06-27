using System;
using System.Collections.Generic;
using System.Linq;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                list.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int indexOne = indexes[0];
            int indexTwo = indexes[1];
        }


    }
}
