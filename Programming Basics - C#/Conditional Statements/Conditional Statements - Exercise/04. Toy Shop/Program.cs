using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());

            // Toys count
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int teddybearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            // Sum of toys count
            int toysCountSum = puzzlesCount + dollsCount + teddybearsCount + minionsCount + trucksCount;

            // Toys prices
            double puzzlePrice = puzzlesCount * 2.6;
            double dollsPrice = dollsCount * 3;
            double teddybearPrice = teddybearsCount * 4.1;
            double minionsPrice = minionsCount * 8.2;
            double truckPrice = trucksCount * 2;

            double totalPrice = puzzlePrice + dollsPrice + teddybearPrice + minionsPrice + truckPrice;

            if (toysCountSum >= 50)
            {
                totalPrice *= 0.75;
            }

            totalPrice *= 0.9;

            if (totalPrice >= tripCost)
            {
                Console.WriteLine($"Yes! {(totalPrice - tripCost):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripCost - totalPrice):f2} lv needed.");
            }
        }
    }
}
