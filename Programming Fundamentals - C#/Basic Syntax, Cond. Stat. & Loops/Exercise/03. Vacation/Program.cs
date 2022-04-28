using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        totalPrice = numOfPeople * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = numOfPeople * 9.8;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = numOfPeople * 10.46;
                    }
                    if (numOfPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;

                case "Business":
                    if (numOfPeople >= 100)
                    {
                        numOfPeople -= 10;
                    }
                    if (day == "Friday")
                    {
                        totalPrice = numOfPeople * 10.9;
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = numOfPeople * 15.6;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = numOfPeople * 16;
                    }
                    break;

                case "Regular":
                    if (day == "Friday")
                    {
                        totalPrice = numOfPeople * 15;
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = numOfPeople * 20;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = numOfPeople * 22.5;
                    }
                    if (numOfPeople >= 10 && numOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
