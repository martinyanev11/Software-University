using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> bracketsIndexes = new Stack<int>();
            string subExpression = string.Empty;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    bracketsIndexes.Push(i);
                }
                if (expression[i] == ')')
                {
                    int startIndex = bracketsIndexes.Pop();
                    int endIndex = i;

                    subExpression = expression.Substring(startIndex, (endIndex - startIndex + 1));
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
