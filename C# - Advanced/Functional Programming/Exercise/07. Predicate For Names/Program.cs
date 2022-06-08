using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthLimit = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> nameLengthCheck = name => name.Length <= lengthLimit;

            List<string> filteredNames = names.FindAll(nameLengthCheck);

            Action<string> print = name => Console.WriteLine(name);

            filteredNames.ForEach(print);
        }
    }
}
