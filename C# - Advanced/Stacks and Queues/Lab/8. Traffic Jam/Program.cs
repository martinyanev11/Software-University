using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of cars to pass on green light
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passedCarsCounter = 0;

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (cars.Count > 0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCarsCounter++;
                            if (cars.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine($"{passedCarsCounter} cars passed the crossroads.");
        }
    }
}
