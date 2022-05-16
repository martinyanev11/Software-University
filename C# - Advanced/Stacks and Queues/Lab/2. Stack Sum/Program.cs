using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>(numbersArray);

            while (true)
            {
                string cmdInput = Console.ReadLine();
                cmdInput = cmdInput.ToLower();

                if (cmdInput == "end")
                {
                    break;
                }

                string[] cmdArgs = cmdInput.Split();
                string command = cmdArgs[0];
                if (command == "add")
                {
                    int num1 = int.Parse(cmdArgs[1]);
                    int num2 = int.Parse(cmdArgs[2]);

                    numbersStack.Push(num1);
                    numbersStack.Push(num2);
                }
                else if (command == "remove")
                {
                    int timesToPop = int.Parse(cmdArgs[1]);
                    if (timesToPop <= numbersStack.Count - 1)
                    {
                        for (int i = 0; i < timesToPop; i++)
                        {
                            numbersStack.Pop();
                        }                     
                    }
                }
            }

            int sum = numbersStack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
