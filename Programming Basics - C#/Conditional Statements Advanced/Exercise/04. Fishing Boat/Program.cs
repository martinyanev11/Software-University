using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermansNumber = int.Parse(Console.ReadLine());

            double boatRent = 0;

            switch (season)
            {
                case "Spring":
                    boatRent = 3000;
                    if (fishermansNumber <= 6)
                    {
                        boatRent *= 0.9;
                    }
                    else if (fishermansNumber > 6 && fishermansNumber <= 11)
                    {
                        boatRent *= 0.85;
                    }
                    else
                    {
                        boatRent *= 0.75;
                    }
                    if (fishermansNumber % 2 == 0)
                    {
                        boatRent *= 0.95;
                    }
                    if (budget >= boatRent)
                    {
                        Console.WriteLine($"Yes! You have {(budget - boatRent):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(boatRent - budget):f2} leva.");
                    }
                    break;

                case "Summer":
                    boatRent = 4200;
                    if (fishermansNumber <= 6)
                    {
                        boatRent *= 0.9;
                    }
                    else if (fishermansNumber > 6 && fishermansNumber <= 11)
                    {
                        boatRent *= 0.85;
                    }
                    else
                    {
                        boatRent *= 0.75;
                    }
                    if (fishermansNumber % 2 == 0)
                    {
                        boatRent *= 0.95;
                    }
                    if (budget >= boatRent)
                    {
                        Console.WriteLine($"Yes! You have {(budget - boatRent):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(boatRent - budget):f2} leva.");
                    }
                    break;

                case "Autumn":
                    boatRent = 4200;
                    if (fishermansNumber <= 6)
                    {
                        boatRent *= 0.9;
                    }
                    else if (fishermansNumber > 6 && fishermansNumber <= 11)
                    {
                        boatRent *= 0.85;
                    }
                    else
                    {
                        boatRent *= 0.75;
                    }
                    if (budget >= boatRent)
                    {
                        Console.WriteLine($"Yes! You have {(budget - boatRent):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(boatRent - budget):f2} leva.");
                    }
                    break;

                case "Winter":
                    boatRent = 2600;
                    if (fishermansNumber <= 6)
                    {
                        boatRent *= 0.9;
                    }
                    else if (fishermansNumber > 6 && fishermansNumber <= 11)
                    {
                        boatRent *= 0.85;
                    }
                    else
                    {
                        boatRent *= 0.75;
                    }
                    if (fishermansNumber % 2 == 0)
                    {
                        boatRent *= 0.95;
                    }
                    if (budget >= boatRent)
                    {
                        Console.WriteLine($"Yes! You have {(budget - boatRent):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(boatRent - budget):f2} leva.");
                    }
                    break;
            }
        }
    }
}
