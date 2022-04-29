using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int midNumber = 0;
            int minNumber = 0;

            if (number1 > number3 && number1 > number2)
            {
                midNumber = Math.Max(number2, number3);
                minNumber = Math.Min(number2, number3);

                Console.WriteLine(number1);
                Console.WriteLine(midNumber);
                Console.WriteLine(minNumber);
            }
            else if (number2 > number1 && number2 > number3)
            {
                midNumber = Math.Max(number1, number3);
                minNumber = Math.Min(number1, number3);

                Console.WriteLine(number2);
                Console.WriteLine(midNumber);
                Console.WriteLine(minNumber);
            }
            else if (number3 > number1 && number3 > number2)
            {
                midNumber = Math.Max(number1, number2);
                minNumber = Math.Min(number1, number2);

                Console.WriteLine(number3);
                Console.WriteLine(midNumber);
                Console.WriteLine(minNumber);
            }





        }
    }
}
