using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conditionsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numElementsToPush = conditionsInput[0];
            int numElementsToPop = conditionsInput[1];
            int elementToLookFor = conditionsInput[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbersQueue = new Queue<int>();

            for (int i = 0; i < numElementsToPush; i++)
            {
                numbersQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numElementsToPop; i++)
            {
                if (numbersQueue.Count == 0)
                {
                    break;
                }
                numbersQueue.Dequeue();
            }

            if (numbersQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (numbersQueue.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbersQueue.Min());
                }
            }
        }
    }
}
