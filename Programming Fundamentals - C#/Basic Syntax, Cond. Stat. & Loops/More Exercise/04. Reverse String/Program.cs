﻿using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currCr = input[i];
                reversed += currCr;
            }

            Console.WriteLine(reversed);
        }
    }
}
