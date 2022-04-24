using System;

namespace _06._World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double swimTime = distanceInMeters * timeForOneMeter;

            if (distanceInMeters >= 15)
            {
                double delayTimes = Math.Floor(distanceInMeters / 15);
                double waterResistanceDelay = delayTimes * 12.5;

                swimTime = swimTime + waterResistanceDelay;
            }

            if (swimTime >= recordInSeconds)
            {
                Console.WriteLine($"No, he failed! He was {(swimTime - recordInSeconds):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimTime:f2} seconds.");
            }
        }
    }
}
