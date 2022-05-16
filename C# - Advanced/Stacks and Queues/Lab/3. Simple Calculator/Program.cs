using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Array.Reverse(input);

            Stack<string> mathProblem = new Stack<string>(input);

            int firstnumber = int.Parse(mathProblem.Pop());
            int result = firstnumber;

            while (mathProblem.Count > 0)
            {  
                string operation = mathProblem.Pop();
                int number = int.Parse(mathProblem.Pop());

                if (operation == "+")
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
            
            Console.WriteLine(result);
            
        }
    }
}
