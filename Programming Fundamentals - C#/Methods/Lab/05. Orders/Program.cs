using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            TotalPriceMethod(product, quantity);
        }

        static void TotalPriceMethod(string product, int quantity)
        {
            double totalPrice = 0;
            switch (product)
            {
                case "coffee":
                    totalPrice = 1.5 * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;

                case "water":
                    totalPrice = 1 * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;

                case "coke":
                    totalPrice = 1.4 * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;

                case "snacks":
                    totalPrice = 2 * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
            }
        }
    }
}
