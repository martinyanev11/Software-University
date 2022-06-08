using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            // Create action for printing
            Action<string> appendSirAndPrint = x => Console.WriteLine($"Sir {x}");

            foreach (var str in strings)
            {
                // use the action for each string in the array
                appendSirAndPrint(str);
            }
        }
    }
}
