using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            // Price of clothing for 1 statist
            double oneStatistClothesPrice = double.Parse(Console.ReadLine());

            double decorPrice = movieBudget * 0.10;
            double statistsClothesPrice = statistsCount * oneStatistClothesPrice;

            if (statistsCount > 150)
            {
                statistsClothesPrice = statistsClothesPrice - (statistsClothesPrice * 0.1);
            }

            double movieCostsSum = decorPrice + statistsClothesPrice;
            double difference = Math.Abs(movieCostsSum - movieBudget);

            if (movieCostsSum > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
        }
    }
}
