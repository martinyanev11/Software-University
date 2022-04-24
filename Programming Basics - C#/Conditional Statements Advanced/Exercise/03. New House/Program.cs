using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            double flowerQuantity = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowerPrice = 0;
            double totalPrice = 0;

            switch (flower)
            {
                case "Roses":
                    flowerPrice = 5;
                    totalPrice = flowerPrice * flowerQuantity;
                    if (flowerQuantity > 80)
                    {
                        totalPrice *= 0.9;
                    }
                    if (budget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {(budget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");

                    }
                    break;

                case "Dahlias":
                    flowerPrice = 3.80;
                    totalPrice = flowerPrice * flowerQuantity;
                    if (flowerQuantity > 90)
                    {
                        totalPrice *= 0.85;
                    }
                    if (budget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {(budget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");

                    }
                    break;

                case "Tulips":
                    flowerPrice = 2.80;
                    totalPrice = flowerPrice * flowerQuantity;
                    if (flowerQuantity > 80)
                    {
                        totalPrice *= 0.85;
                    }
                    if (budget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {(budget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");

                    }
                    break;

                case "Narcissus":
                    flowerPrice = 3;
                    totalPrice = flowerPrice * flowerQuantity;
                    if (flowerQuantity < 120)
                    {
                        totalPrice *= 1.15;
                    }
                    if (budget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {(budget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");

                    }
                    break;

                case "Gladiolus":
                    flowerPrice = 2.50;
                    totalPrice = flowerPrice * flowerQuantity;
                    if (flowerQuantity < 80)
                    {
                        totalPrice *= 1.20;
                    }
                    if (budget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {(budget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");

                    }
                    break;
            }
        }
    }
}
