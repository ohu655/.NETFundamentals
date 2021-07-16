using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue2
{

    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

  

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] vehicleParts = line.Split();
                string type = vehicleParts[0];
                string model = vehicleParts[1];
                string color = vehicleParts[2];
                int horsePower = int.Parse(vehicleParts[3]);

                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };

                vehicles.Add(vehicle);
               
            }

            while (true)
            {
                string modelOfVehicle = Console.ReadLine();

                if (modelOfVehicle == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = GetVehicleByModel(vehicles, modelOfVehicle);

                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }

                else
                {
                    Console.WriteLine($"Type: Truck");
                }

                
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.HorsePower}");

            }

            double carsHorsePowerAvg = CalcuteAvgHorsePower(vehicles, "car");
            double trucksHorsePowerAvg = CalcuteAvgHorsePower(vehicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsHorsePowerAvg:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHorsePowerAvg:f2}.");

        }

        private static double CalcuteAvgHorsePower(List<Vehicle> vehicles, string type)
        {
            int typeCount = 0;
            int typeHorsePowerTotal = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    typeCount += 1;
                    typeHorsePowerTotal += vehicle.HorsePower;
                }
            }

            if (typeCount == 0)
            {
                return 0;
            }

            return (double)typeHorsePowerTotal / typeCount;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> vehicles, string modelOfVehicle)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == modelOfVehicle)
                {
                    return vehicle;
                }               
            }


            return null;
        }
    }
}
