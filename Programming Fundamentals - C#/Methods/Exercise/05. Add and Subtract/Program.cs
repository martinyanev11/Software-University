using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractResult(AddResult(number1, number2), number3));
        }

        static int AddResult(int number1, int number2)
        {
            return number1 + number2;
        }

        static int SubtractResult(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
