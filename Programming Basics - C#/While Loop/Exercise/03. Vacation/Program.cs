using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoneyForTrip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int daysTotal = 0;
            int daysMoneySpend = 0;

            while (daysMoneySpend != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysTotal++;

                if (input == "save")
                {
                    currentMoney += money;
                    daysMoneySpend = 0;
                }
                else if (input == "spend")
                {
                    daysMoneySpend++;
                    if (money > currentMoney)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= money;
                    }
                }

                if (currentMoney >= neededMoneyForTrip)
                {
                    Console.WriteLine($"You saved the money for {daysTotal} days.");
                    break;
                }
            }

            if (daysMoneySpend == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysTotal);
            }
        }
    }
}
