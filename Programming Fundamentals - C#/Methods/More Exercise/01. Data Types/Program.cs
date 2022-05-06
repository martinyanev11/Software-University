using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int intNumber = int.Parse(Console.ReadLine());
                    int intResult = Multiply(intNumber);
                    Console.WriteLine(intResult);
                    break;
                case "real":
                    double doubleNumber = double.Parse(Console.ReadLine());
                    double doubleResult = Multiply(doubleNumber);
                    Console.WriteLine($"{doubleResult:f2}");
                    break;
                case "string":
                    string @string = Console.ReadLine();
                    Console.WriteLine($"${@string}$");
                    break;
            }
        }

        static int Multiply(int number)
        {
            return number * 2;
        }

        static double Multiply(double number)
        {
            return number * 1.5;
        }
    }
}
