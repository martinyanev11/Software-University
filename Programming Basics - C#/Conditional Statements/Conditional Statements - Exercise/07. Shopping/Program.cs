using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int GPU = int.Parse(Console.ReadLine());
            int CPU = int.Parse(Console.ReadLine());
            int RAM = int.Parse(Console.ReadLine());

            double GPUprice = GPU * 250;
            double CPUprice = CPU * (GPUprice * 0.35);
            double RAMprice = RAM * (GPUprice * 0.1);

            double sum = GPUprice + CPUprice + RAMprice;

            if (GPU > CPU)
            {
                sum = sum - (sum * 0.15);
            }

            if (budget >= sum)
            {
                Console.WriteLine($"You have {(budget - sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(sum - budget):f2} leva more!");
            }
        }
    }
}
