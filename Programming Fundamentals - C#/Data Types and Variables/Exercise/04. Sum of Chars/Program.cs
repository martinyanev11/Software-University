using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += (int)ch;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
