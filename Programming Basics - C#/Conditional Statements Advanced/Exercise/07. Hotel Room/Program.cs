using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":

                    studioPrice = 50;
                    apartmentPrice = 65;

                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        studioPrice *= 0.7;
                        apartmentPrice *= 0.9;
                    }
                    Console.WriteLine($"Apartment: {(nights * apartmentPrice):f2} lv.");
                    Console.WriteLine($"Studio: {(nights * studioPrice):f2} lv.");
                    break;

                case "June":
                case "September":

                    studioPrice = 75.20;
                    apartmentPrice = 68.70;

                    if (nights > 14)
                    {
                        studioPrice *= 0.8;
                        apartmentPrice *= 0.9;
                    }
                    Console.WriteLine($"Apartment: {(nights * apartmentPrice):f2} lv.");
                    Console.WriteLine($"Studio: {(nights * studioPrice):f2} lv.");
                    break;

                case "July":
                case "August":

                    studioPrice = 76;
                    apartmentPrice = 77;

                    if (nights > 14)
                    {
                        apartmentPrice *= 0.9;
                    }
                    Console.WriteLine($"Apartment: {(nights * apartmentPrice):f2} lv.");
                    Console.WriteLine($"Studio: {(nights * studioPrice):f2} lv.");
                    break;
            }
        }
    }
}
