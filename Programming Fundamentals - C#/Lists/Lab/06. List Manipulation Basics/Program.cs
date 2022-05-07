using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                switch (cmdArgs[0])
                {
                    case "Add":
                        numbersList.Add(int.Parse(cmdArgs[1]));
                        break;
                    case "Remove":
                        numbersList.RemoveAll(x => x == int.Parse(cmdArgs[1]));
                        break;
                    case "RemoveAt":
                        numbersList.RemoveAt(int.Parse(cmdArgs[1]));
                        break;
                    case "Insert":
                        numbersList.Insert(int.Parse(cmdArgs[2]), int.Parse(cmdArgs[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
