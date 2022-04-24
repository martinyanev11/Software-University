using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        amount = amount * 0.5;
                        Console.WriteLine(amount);
                        break;
                    case "water":
                        amount = amount * 0.8;
                        Console.WriteLine(amount);
                        break;
                    case "beer":
                        amount = amount * 1.2;
                        Console.WriteLine(amount);
                        break;
                    case "sweets":
                        amount = amount * 1.45;
                        Console.WriteLine(amount);
                        break;
                    case "peanuts":
                        amount = amount * 1.6;
                        Console.WriteLine(amount);
                        break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        amount = amount * 0.4;
                        Console.WriteLine(amount);
                        break;
                    case "water":
                        amount = amount * 0.7;
                        Console.WriteLine(amount);
                        break;
                    case "beer":
                        amount = amount * 1.15;
                        Console.WriteLine(amount);
                        break;
                    case "sweets":
                        amount = amount * 1.3;
                        Console.WriteLine(amount);
                        break;
                    case "peanuts":
                        amount = amount * 1.5;
                        Console.WriteLine(amount);
                        break;
                }
            }
            else
            {
                switch (product)
                {
                    case "coffee":
                        amount = amount * 0.45;
                        Console.WriteLine(amount);
                        break;
                    case "water":
                        amount = amount * 0.7;
                        Console.WriteLine(amount);
                        break;
                    case "beer":
                        amount = amount * 1.1;
                        Console.WriteLine(amount);
                        break;
                    case "sweets":
                        amount = amount * 1.35;
                        Console.WriteLine(amount);
                        break;
                    case "peanuts":
                        amount = amount * 1.55;
                        Console.WriteLine(amount);
                        break;
                }
            }
        }
    }
}
