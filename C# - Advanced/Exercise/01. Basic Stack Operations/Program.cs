using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < numElementsToPush; i++)
            {
                numbersStack.Push(numbers[i]);
            }

            for (int i = 0; i < numElementsToPop; i++)
            {
                if (numbersStack.Count == 0)
                {
                    break;
                }
                numbersStack.Pop();
            }

            if (numbersStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (numbersStack.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbersStack.Min());
                }
            }
        }
    }
}
