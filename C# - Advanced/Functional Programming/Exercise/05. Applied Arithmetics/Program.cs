using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string operation;
            Func<List<int>, List<int>> function;
            Action<List<int>> printAction = list => Console.WriteLine(string.Join(" ", list));


            while ((operation = Console.ReadLine()) != "end")
            {
                if (operation == "add")
                {
                    function = list => list.Select(num => num += 1).ToList();
                    numbers = function(numbers);
                }
                else if (operation == "multiply")
                {
                    function = list => list.Select(x => x *= 2).ToList();
                    numbers = function(numbers);
                }
                else if (operation == "subtract")
                {
                    function = list => list.Select(x => x -= 1).ToList();
                    numbers = function(numbers);
                }
                else if (operation == "print")
                {
                    printAction(numbers);
                }
            }
        }
    }
}
