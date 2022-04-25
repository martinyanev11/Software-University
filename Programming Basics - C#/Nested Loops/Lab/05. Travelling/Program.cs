using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination;
            while ((destination = Console.ReadLine()) != "End")
            {
                double priceToVisit = double.Parse(Console.ReadLine());
                double savedMoneyTotal = 0;

                while (priceToVisit > savedMoneyTotal)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    savedMoneyTotal += savedMoney;
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
