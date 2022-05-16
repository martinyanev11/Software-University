using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split();

            Stack<string> subExpression = new Stack<string>();

            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == "(")
                {
                    // -2:13 min on stream https://softuni.bg/trainings/live/details?trainingLabId=85
                    // to be continued.
                }
            }
        }
    }
}
