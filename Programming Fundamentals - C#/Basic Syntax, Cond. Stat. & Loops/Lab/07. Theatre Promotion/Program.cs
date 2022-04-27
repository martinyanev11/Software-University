using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (age >= 0 && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                }
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
