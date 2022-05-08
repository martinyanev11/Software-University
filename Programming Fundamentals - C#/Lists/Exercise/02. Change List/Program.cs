using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                if (cmdArgs[0] == "Delete")
                {
                    numberList.RemoveAll(x => x == int.Parse(cmdArgs[1]));
                }
                else
                {
                    numberList.Insert(int.Parse(cmdArgs[2]), int.Parse(cmdArgs[1]));
                }
            }
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
