using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());

            while (startPoint <= endPoint)
            {
                char ch = (char)startPoint;
                Console.Write($"{ch} ");
                startPoint++;
            }
        }
    }
}
