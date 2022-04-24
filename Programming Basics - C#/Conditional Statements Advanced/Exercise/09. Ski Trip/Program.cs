using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            // USER INPUT
            double nights = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            nights -= 1;
            double totalPrice = 0;

            // CONST PRICES
            const double roomForOnePerson = 18;
            const double apartment = 25;
            const double presidentApartment = 35;

            switch (roomType)
            {
                case "apartment":
                    totalPrice = nights * apartment;
                    if (nights < 10)
                    {
                        totalPrice *= 0.7;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        totalPrice *= 0.65;
                    }
                    else if (nights > 15)
                    {
                        totalPrice *= 0.5;
                    }
                    break;
                case "president apartment":
                    totalPrice = nights * presidentApartment;
                    if (nights < 10)
                    {
                        totalPrice *= 0.9;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        totalPrice *= 0.85;
                    }
                    else if (nights > 15)
                    {
                        totalPrice *= 0.8;
                    }
                    break;
                default:
                    totalPrice = nights * roomForOnePerson;
                    break;
            }

            if (rating == "positive")
            {
                totalPrice = totalPrice + (totalPrice * 0.25);
            }
            else
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
