using System;

namespace _01._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmPerHour = double.Parse(Console.ReadLine());
            double litersFuelPer100Km = double.Parse(Console.ReadLine());

            double kmToMoon = 384400;
            kmToMoon *= 2;

            double timeToTravel = Math.Ceiling(kmToMoon / kmPerHour);
            timeToTravel += 3;

            double fuelNeeded = (litersFuelPer100Km * kmToMoon) / 100;

            Console.WriteLine(timeToTravel);
            Console.WriteLine(fuelNeeded);
        }
    }
}
