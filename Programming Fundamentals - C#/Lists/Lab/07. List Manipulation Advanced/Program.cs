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
            bool changesAreMade = false;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                switch (cmdArgs[0])
                {
                    case "Add":
                        numbersList.Add(int.Parse(cmdArgs[1]));
                        changesAreMade = true;
                        break;
                    case "Remove":
                        numbersList.RemoveAll(x => x == int.Parse(cmdArgs[1]));
                        changesAreMade = true;
                        break;
                    case "RemoveAt":
                        numbersList.RemoveAt(int.Parse(cmdArgs[1]));
                        changesAreMade = true;
                        break;
                    case "Insert":
                        numbersList.Insert(int.Parse(cmdArgs[2]), int.Parse(cmdArgs[1]));
                        changesAreMade = true;
                        break;
                    case "Contains":
                        if (numbersList.Contains(int.Parse(cmdArgs[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbersList.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbersList.Where(x => x % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbersList.Sum());
                        break;
                    case "Filter":
                        Filter(numbersList, cmdArgs[1], int.Parse(cmdArgs[2]));
                        break;
                }
            }
            if (changesAreMade == true)
            {
                Console.WriteLine(string.Join(" ", numbersList));
            }
        }

        static void Filter(List<int> numbersList, string condition, int number)
        {
            switch (condition)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", numbersList.Where(x => x < number)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", numbersList.Where(x => x > number)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", numbersList.Where(x => x >= number)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", numbersList.Where(x => x <= number)));
                    break;
            }
        }
    }
}
