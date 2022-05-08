using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> partyList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] cmdArgs = input.Split();

                // IF {NAME} IS GOING
                if (cmdArgs[2] == "going!")
                {
                    if (!partyList.Contains(cmdArgs[0]))
                    {
                        partyList.Add(cmdArgs[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArgs[0]} is already in the list!");
                    }
                }
                // IF {NAME} IS NOT GOING
                else
                {
                    if (partyList.Contains(cmdArgs[0]))
                    {
                        partyList.Remove(cmdArgs[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArgs[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < partyList.Count; i++)
            {
                Console.WriteLine(partyList[i]);
            }
        }
    }
}
