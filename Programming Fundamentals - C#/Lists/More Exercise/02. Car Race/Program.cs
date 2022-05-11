using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> firstRacer = new List<int>();
            List<int> secondRacer = new List<int>();

            int finishLine = inputList.Count / 2 + 1;

            for (int i = 0; i < finishLine - 1; i++)
            {
                firstRacer.Add(inputList[i]);
            }
            for (int i = finishLine; i < inputList.Count; i++)
            {
                secondRacer.Add(inputList[i]);
            }

            secondRacer.Reverse();

            decimal firstRacerSum = 0;
            decimal secondRacerSum = 0;

            for (int i = 0; i < firstRacer.Count; i++)
            {
                if (firstRacer[i] == 0)
                {
                    firstRacerSum *= 0.8M;
                }
                firstRacerSum += firstRacer[i];
            }

            for (int i = 0; i < secondRacer.Count; i++)
            {
                if (secondRacer[i] == 0)
                {
                    secondRacerSum *= 0.8M;
                }
                secondRacerSum += secondRacer[i];
            }

            if (firstRacerSum < secondRacerSum)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerSum}");
            }
        }
    }
}
