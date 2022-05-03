using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = new string(Console.ReadLine()).Split();
            Array.Reverse(stringArr);
            Console.WriteLine(string.Join(" ", stringArr));
        }
    }
}

