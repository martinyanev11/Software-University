using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class PetrolStation
    {
        public int AmountOfPetrol { get; set; }

        public int KmToNextStation { get; set; }

        public int Index { get; set; }

        public PetrolStation(int index, int fuel, int km)
        {
            this.Index = index;
            this.AmountOfPetrol = fuel;
            this.KmToNextStation = km;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolStations = int.Parse(Console.ReadLine());
            PetrolStation[] stationsArr = new PetrolStation[numberOfPetrolStations - 1];

            for (int i = 0; i < numberOfPetrolStations; i++)
            {
                int fuel = int.Parse(Console.ReadLine());
                int km = int.Parse(Console.ReadLine());
                PetrolStation newStation = new PetrolStation(i, fuel, km);

                stationsArr[i] = newStation;
            }

            Queue<PetrolStation> stationsQueue = new Queue<PetrolStation>(stationsArr);

            int truckCurrentFuel = 0;
            int currentStatingStationIndex = 0;

            bool circleIsComplete = false;
            bool truckIsOutOfFuel = false;

            for (int i = 0; i < numberOfPetrolStations; i++)
            {
                foreach (var station in stationsQueue)
                {
                    if (truckCurrentFuel + station.AmountOfPetrol < station.KmToNextStation)
                    {
                        truckIsOutOfFuel = true;
                        break;
                    }
                    else
                    {

                    }
            }
        }
    }
}
