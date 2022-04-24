using System;

namespace _06._OpsBetweenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {result} - odd");
                    }
                    break;

                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {result} - odd");
                    }
                    break;

                case "*":
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {result} - odd");
                    }
                    break;

                case "/":
                    result = num1 / num2;
                    if (num1 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num2} by zero");
                    }
                    else if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    break;

                case "%":
                    result = num1 % num2;
                    if (num1 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num2} by zero");
                    }
                    else if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    break;
            }
        }
    }
}
