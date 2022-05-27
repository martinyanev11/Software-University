using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = cmdArgs[0];
                string carNumber = cmdArgs[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }
            }

            if (parkingLot.Count != 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
