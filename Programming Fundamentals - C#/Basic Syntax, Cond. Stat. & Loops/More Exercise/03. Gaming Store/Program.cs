using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            // GAME PRICES
            double g1 = 39.99;
            double g2 = 15.99;
            double g3 = 19.99;
            double g4 = 59.99;
            double g5 = 29.99;
            double g6 = 39.99;

            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpend = 0;
            bool isGameTime = false;

            while (isGameTime == false)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Game Time":
                        isGameTime = true;
                        Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${currentBalance:f2}");
                        break;
                    case "OutFall 4":
                        if (currentBalance >= g1)
                        {
                            currentBalance -= g1;
                            totalSpend += g1;
                            Console.WriteLine($"Bought { input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (currentBalance >= g2)
                        {
                            currentBalance -= g2;
                            totalSpend += g2;
                            Console.WriteLine($"Bought { input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance >= g3)
                        {
                            currentBalance -= g3;
                            totalSpend += g3;
                            Console.WriteLine($"Bought { input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalance >= g4)
                        {
                            currentBalance -= g4;
                            totalSpend += g4;
                            Console.WriteLine($"Bought { input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalance >= g5)
                        {
                            currentBalance -= g5;
                            totalSpend += g5;
                            Console.WriteLine($"Bought { input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= g6)
                        {
                            currentBalance -= g6;
                            totalSpend += g6;
                            Console.WriteLine($"Bought { input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
