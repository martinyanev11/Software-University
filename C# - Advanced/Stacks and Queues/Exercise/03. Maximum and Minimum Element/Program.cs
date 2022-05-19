using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //number of inputs

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] cmdArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int commandType = cmdArgs[0];

                // 1 == push in the stack
                if (commandType == 1)
                {
                    stack.Push(cmdArgs[1]);
                }
                // 2 == pop out of the stack
                else if (commandType == 2)
                {
                    // If stack is empty
                    if (!stack.Any())
                    {
                        continue;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                // 3 == print max element
                else if (commandType == 3)
                {
                    // If stack is empty
                    if (!stack.Any())
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                // 4 == print min element
                else if (commandType == 4)
                {
                    // If stack is empty
                    if (!stack.Any())
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
