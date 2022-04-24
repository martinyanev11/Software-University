using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // USER INPUT
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            // FRUIT PRICES FOR WORK DAYS
            const double bananaWorkDayPrice = 2.50;
            const double appleWorkDayPrice = 1.20;
            const double orangeWorkDayPrice = 0.85;
            const double grapefruitWorkDayPrice = 1.45;
            const double kiwiWorkDayPrice = 2.70;
            const double pineappleWorkDayPrice = 5.50;
            const double grapesWorkDayPrice = 3.85;

            // FRUIT PRICES FOR WEEKENDS
            const double bananaWeekendPrice = 2.70;
            const double appleWeekendPrice = 1.25;
            const double orangeWeekendPrice = 0.90;
            const double grapefruitWeekendPrice = 1.60;
            const double kiwiWeekendPrice = 3.00;
            const double pineappleWeekendPrice = 5.60;
            const double grapesWeekendPrice = 4.20;

            // IF THE DAY IS WEEKEND
            if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{(amount * bananaWeekendPrice):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(amount * appleWeekendPrice):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(amount * orangeWeekendPrice):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(amount * grapefruitWeekendPrice):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(amount * kiwiWeekendPrice):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(amount * pineappleWeekendPrice):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(amount * grapesWeekendPrice):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            // IF DAY IS WORK DAY
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{(amount * bananaWorkDayPrice):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(amount * appleWorkDayPrice):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(amount * orangeWorkDayPrice):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(amount * grapefruitWorkDayPrice):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(amount * kiwiWorkDayPrice):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(amount * pineappleWorkDayPrice):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(amount * grapesWorkDayPrice):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            // IF NONE OF THE ABOVE
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
