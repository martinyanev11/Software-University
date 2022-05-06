using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            WriteCharachters(char1, char2);
        }

        static void WriteCharachters(char char1, char char2)
        {
            int char1Value = (int)char1;
            int char2Value = (int)char2;

            if (char1Value > char2Value)
            {
                char1Value = (int)char2;
                char2Value = (int)char1;
            }

            for (int i = char1Value + 1; i < char2Value; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
