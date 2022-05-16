using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();

            foreach (char letter in input)
            {
                stack.Push(letter);
            }

            for (int i = stack.Count - 1; i >= 0; i--)
            {
                char currLetter = stack.Pop();
                Console.Write(currLetter);
            }
            Console.WriteLine();
        }
    }
}
