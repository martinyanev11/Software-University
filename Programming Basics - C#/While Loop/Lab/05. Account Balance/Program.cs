using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string sumToDeposit = Console.ReadLine();
            double sumTotal = 0;

            while (sumToDeposit != "NoMoreMoney")
            {
                double sumConvertedDeposit = double.Parse(sumToDeposit);

                if (sumConvertedDeposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sumTotal:f2}");
                    break;
                }

                sumTotal += sumConvertedDeposit;
                Console.WriteLine($"Increase: {sumConvertedDeposit:f2}");
                sumToDeposit = Console.ReadLine();
            }

            if (sumToDeposit == "NoMoreMoney")
            {
                Console.WriteLine($"Total: {sumTotal:f2}");
            }

        }
    }
}
