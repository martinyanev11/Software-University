using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            double coinsCounter = 0;

            while (change != 0)
            {
                if (change >= 2)
                {
                    change -= 2;
                    coinsCounter++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    coinsCounter++;
                }
                else if (change >= 0.5M)
                {
                    change -= 0.5M;
                    coinsCounter++;
                }
                else if (change >= 0.2M)
                {
                    change -= 0.2M;
                    coinsCounter++;
                }
                else if (change >= 0.1M)
                {
                    change -= 0.1M;
                    coinsCounter++;
                }
                else if (change >= 0.05M)
                {
                    change -= 0.05M;
                    coinsCounter++;
                }
                else if (change >= 0.02M)
                {
                    change -= 0.02M;
                    coinsCounter++;
                }
                else if (change >= 0.01M)
                {
                    change -= 0.01M;
                    coinsCounter++;
                }
            }

            Console.WriteLine(coinsCounter);
        }
    }
}
