using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                if (cmdArgs[0] == "Add")
                {
                    trainWagons.Add(int.Parse(cmdArgs[1]));
                }
                else
                {
                    int passengers = int.Parse(cmdArgs[0]);
                    for (int i = 0; i < trainWagons.Count; i++)
                    {
                        if (trainWagons[i] + passengers <= maxCapacity)
                        {
                            trainWagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", trainWagons));
        }
    }
}
