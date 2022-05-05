using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatOfString(input, repeatNumber));
            Console.WriteLine();
        }

        static string RepeatOfString(string stringToRepeat, int timesToRepeat)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < timesToRepeat; i++)
            {
                stringBuilder.Append(stringToRepeat);
            }

            return stringBuilder.ToString();
        }
    }
}
