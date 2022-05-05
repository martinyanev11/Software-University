using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculation(firstNumber, @operator, secondNumber));
        }

        static int Calculation(int firstNumber, string @operator, int secondNumber)
        {
            int result = 0;
            switch (@operator)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }
            return result;
        }
    }
}
