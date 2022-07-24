using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carLitersPerKm = double.Parse(carInfo[2]);
            Car car = new Car(carFuelQuantity, carLitersPerKm);

            string[] truckInfo = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]);
            Truck truck = new Truck(truckFuelQuantity, truckLitersPerKm);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string command = cmdArgs[0];
                switch (command)
                {
                    case "Drive":
                        double distanceToDrive = double.Parse(cmdArgs[2]);
                        if (cmdArgs[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(distanceToDrive)); 
                        }
                        else
                        {
                            Console.WriteLine(truck.Drive(distanceToDrive));
                        }
                        break;

                    case "Refuel":
                        double amountToRefuel = double.Parse(cmdArgs[2]);
                        if (cmdArgs[1] == "Car")
                        {
                            car.Refuel(amountToRefuel);
                        }
                        else
                        {
                            truck.Refuel(amountToRefuel);
                        }
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
