using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberToPrint = 1;
            bool donePrinting = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = -1; j < i; j++)
                {
                    Console.Write($"{numberToPrint} ");
                    numberToPrint++;

                    if (numberToPrint - 1 == n)
                    {
                        donePrinting = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (donePrinting)
                {
                    break;
                }

            }
        }
    }
}
