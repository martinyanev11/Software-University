﻿using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int counter = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[counter] == firstArray[j])
                    {
                        Console.Write($"{secondArray[counter]} ");
                    }
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}