using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Capacity = capacity;
            CarsCollection = new List<Car>();
        }

        public List<Car> CarsCollection { get; set; }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count
        {
            get { return CarsCollection.Count; }
            //set { count = value; }
        }


        public string AddCar(Car car)
        {
            if (CarsCollection.Any(listedCar => listedCar.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else
            {
                if (CarsCollection.Count >= Capacity)
                {
                    return "Parking is full!";
                }
                else
                {
                    CarsCollection.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            }
            
        }

        public string RemoveCar(string registrationNumber)
        {
            if (CarsCollection.Any(x => x.RegistrationNumber == registrationNumber))
            {
                CarsCollection.RemoveAll(x => x.RegistrationNumber == registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return CarsCollection.First(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {

        }
    }
}
