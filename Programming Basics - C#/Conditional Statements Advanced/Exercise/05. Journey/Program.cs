using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double moneySpent = 0;
            string location = "";
            string sleepLocation = "";

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        sleepLocation = "Camp";
                        moneySpent = budget * 0.3;
                        location = "Bulgaria";
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"{sleepLocation} - {moneySpent:f2}");
                        break;

                    case "winter":
                        sleepLocation = "Hotel";
                        moneySpent = budget * 0.7;
                        location = "Bulgaria";
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"{sleepLocation} - {moneySpent:f2}");
                        break;
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                switch (season)
                {
                    case "summer":
                        sleepLocation = "Camp";
                        moneySpent = budget * 0.4;
                        location = "Balkans";
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"{sleepLocation} - {moneySpent:f2}");
                        break;

                    case "winter":
                        sleepLocation = "Hotel";
                        moneySpent = budget * 0.8;
                        location = "Balkans";
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"{sleepLocation} - {moneySpent:f2}");
                        break;
                }
            }
            else
            {
                sleepLocation = "Hotel";
                moneySpent = budget * 0.9;
                location = "Europe";
                Console.WriteLine($"Somewhere in {location}");
                Console.WriteLine($"{sleepLocation} - {moneySpent:f2}");
            }
        }
    }
}
