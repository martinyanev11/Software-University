using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split().ToList();

            Action<string> printAction = x => Console.WriteLine(x);
            strings.ForEach(printAction);
        }
    }
}
