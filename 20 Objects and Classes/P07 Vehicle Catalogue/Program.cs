using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalog newList = new Catalog();      

            newList.Trucks = new List<Truck>();
            newList.Cars = new List<Car>();

            while (command != "end")
            {
                string[] commandArgs = command.Split("/");
                string typeVehicle = commandArgs[0];
                string brand = commandArgs[1];
                string model = commandArgs[2];
                double weightHorsePower = int.Parse(commandArgs[3]);

                if(typeVehicle == "Truck")
                {
                    Truck newTruck = new Truck();
                    newTruck.Brand = brand;
                    newTruck.Model = model;
                    newTruck.Weight = weightHorsePower;

                    newList.Trucks.Add(newTruck);
                }
                else if(typeVehicle == "Car")
                {
                    Car newCar = new Car();
                    newCar.Brand = brand;
                    newCar.Model = model;
                    newCar.HorsePower = weightHorsePower;

                    newList.Cars.Add(newCar);
                }

                command = Console.ReadLine();
            }

            if(newList.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in newList.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if(newList.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in newList.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
