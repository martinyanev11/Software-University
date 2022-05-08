using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List = Console.ReadLine().Split().ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split();
                switch (cmdArgs[0])
                {
                    case "merge":
                        int mergeStartIndex = int.Parse(cmdArgs[1]);
                        int mergeEndIndex = int.Parse(cmdArgs[2]);
                        if (mergeStartIndex >= 0 && mergeEndIndex < List.Count)
                        {
                            for (int i = mergeStartIndex + 1; i <= mergeEndIndex; i++)
                            {
                                List[mergeStartIndex] += List[i];
                                List[i] = string.Empty;
                            }
                        }
                        break;

                    case "divide":
                        int divideIndex = int.Parse(cmdArgs[1]);
                        int partitions = int.Parse(cmdArgs[2]);

                        int indexLenght = List[divideIndex].Length;
                        if (indexLenght % partitions == 0)
                        {

                        }
                        break;
                }
            }
        }
    }
}
