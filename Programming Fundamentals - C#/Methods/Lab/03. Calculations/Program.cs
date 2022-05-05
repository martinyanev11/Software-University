using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operationType = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (operationType)
            {
                case "add":
                    AddMethod(num1, num2);
                    break;

                case "multiply":
                    MultiplyMethod(num1, num2);
                    break;

                case "subtract":
                    SubtractMethod(num1, num2);
                    break;

                case "divide":
                    DivideMethod(num1, num2);
                    break;
            }
        }

        static void AddMethod(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        static void MultiplyMethod(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine(result);
        }

        static void SubtractMethod(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine(result);
        }

        static void DivideMethod(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine(result);
        }
    }
}
