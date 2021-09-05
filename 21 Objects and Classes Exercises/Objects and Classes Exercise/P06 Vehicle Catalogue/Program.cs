using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Vehicle_Catalogue
{
    class Vehicles
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Vehicles> newList = new List<Vehicles>();

            double carHorsePower = 0;
            int carCount = 0;
            double truckHorsePower = 0;
            int truckCount = 0;

            while (command != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string typeVehicle = commandArgs[0];
                string modelVehicle = commandArgs[1];
                string colorVehicle = commandArgs[2];
                double horsePowerVehicle = double.Parse(commandArgs[3]);

                if (typeVehicle == "car")
                {
                    carHorsePower += horsePowerVehicle;
                    carCount++;
                }
                else if (typeVehicle == "truck")
                {
                    truckHorsePower += horsePowerVehicle;
                    truckCount++;
                }

                Vehicles newCarOrTruck = new Vehicles();
                newCarOrTruck.Type = typeVehicle;
                newCarOrTruck.Model = modelVehicle;
                newCarOrTruck.Color = colorVehicle;
                newCarOrTruck.HorsePower = horsePowerVehicle;

                newList.Add(newCarOrTruck);

                command = Console.ReadLine();
            }

            string models = Console.ReadLine();

            while (models != "Close the Catalogue")
            {
                int modelIndex = newList.FindIndex(n => n.Model == models);            

                Console.WriteLine($"Type: {char.ToUpper(newList[modelIndex].Type[0]) + newList[modelIndex].Type.Substring(1)}");
                Console.WriteLine($"Model: {newList[modelIndex].Model}");
                Console.WriteLine($"Color: {newList[modelIndex].Color}");
                Console.WriteLine($"Horsepower: {newList[modelIndex].HorsePower}");

                models = Console.ReadLine();
            }

            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carHorsePower / carCount:F2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower / truckCount:F2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }

        }
    }
}
