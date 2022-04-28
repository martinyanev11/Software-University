using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double coinSum = 0;
            double currentCoin = 0;
            bool acceptingCoin = true;
            bool givingProducts = true;

            while (acceptingCoin)
            {
                string clientInput = Console.ReadLine();
                if (clientInput == "Start")
                {
                    acceptingCoin = false;
                    break;
                }

                currentCoin = double.Parse(clientInput);
                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
                {
                    coinSum += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
            }

            while (givingProducts)
            {
                string clientInput = Console.ReadLine();
                if (clientInput == "End")
                {
                    givingProducts = false;
                    Console.WriteLine($"Change: {coinSum:f2}");
                    break;
                }
                switch (clientInput)
                {
                    case "Nuts":
                        if (coinSum >= 2)
                        {
                            Console.WriteLine($"Purchased nuts");
                            coinSum -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coinSum >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            coinSum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coinSum >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            coinSum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coinSum >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            coinSum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coinSum >= 1)
                        {
                            Console.WriteLine($"Purchased coke");
                            coinSum -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
        }
    }
}
