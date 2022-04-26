using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName;
            double totalTicketsCount = 0;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidsTickets = 0;

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                double freeSeats = double.Parse(Console.ReadLine());  

                double currentMovieTicketsCount = 0;
                bool endIsGiven = false;

                for (int i = 0; i < freeSeats; i++)
                {
                    if (endIsGiven)
                    {
                        break;
                    }

                    string ticketType = Console.ReadLine();

                    switch (ticketType)
                    {
                        case "student":
                            currentMovieTicketsCount++;
                            studentTickets++;
                            break;

                        case "standard":
                            currentMovieTicketsCount++;
                            standardTickets++;
                            break;

                        case "kid":
                            currentMovieTicketsCount++;
                            kidsTickets++;
                            break;

                        case "End":
                            endIsGiven = true;
                            break;
                    }
                }

                double percentageHallFill = (currentMovieTicketsCount / freeSeats) * 100;

                Console.WriteLine($"{ movieName} - {percentageHallFill:f2}% full.");

                totalTicketsCount += currentMovieTicketsCount;
            }

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{((studentTickets / totalTicketsCount) * 100):f2}% student tickets.");
            Console.WriteLine($"{((standardTickets / totalTicketsCount) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((kidsTickets / totalTicketsCount) * 100):f2}% kids tickets.");
        }
    }
}
