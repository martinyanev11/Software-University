using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int locationsNumber = int.Parse(Console.ReadLine()); // number of locations
            double totalGold = 0;

            for (int i = 0; i < locationsNumber; i++) // number of cycles per location
            {
                double averageGoldPerDayExpected = double.Parse(Console.ReadLine());
                int daysInLocation = int.Parse(Console.ReadLine());

                for (int days = 0; days < daysInLocation; days++) // number of cycles per day in location
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    totalGold += goldPerDay;       
                }

                double averageGold = totalGold / daysInLocation;

                if (averageGold >= averageGoldPerDayExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {(averageGoldPerDayExpected - averageGold):f2} gold.");
                }
                totalGold = 0;
            }
            

        }
    }
}
