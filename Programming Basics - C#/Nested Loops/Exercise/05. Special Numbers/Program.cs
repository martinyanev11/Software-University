using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int delimiter = 10;

            for (int i = 1111; i <= 9999; i++)
            {
                int counter = 0;
                int currentNumber = i;

                for (int j = 0; j < 4; j++)
                {
                    int currentNumberToCheck = currentNumber % delimiter;
                    currentNumber /= delimiter;
                    if (currentNumberToCheck == 0)
                    {
                        continue;
                    }

                    if (n % currentNumberToCheck == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 4)
                {
                    Console.Write($"{i} ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
