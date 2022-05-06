using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(OddLengthLetter(input));
            }
            else
            {
                Console.WriteLine(EvenLengthLetters(input));
            }
        }

        static char OddLengthLetter(string input)
        {
            return input[input.Length / 2];
        }

        static string EvenLengthLetters(string input)
        {
            char[] chars = { input[(input.Length / 2) - 1], input[input.Length / 2] };
            string result = new string(chars);
            return result;
        }
    }
}
