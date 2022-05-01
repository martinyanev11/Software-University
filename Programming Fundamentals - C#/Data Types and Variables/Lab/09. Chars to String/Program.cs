using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            string combined = ($"{ch1}{ch2}{ch3}");
            Console.WriteLine($"{combined}");
        }
    }
}
