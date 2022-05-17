using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (int num in numbersInput)
            {
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            queue.ToArray();
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
