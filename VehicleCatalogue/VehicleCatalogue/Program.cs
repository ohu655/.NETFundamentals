using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            CatalogVehicle catalogueVehicle = new CatalogVehicle();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split('/');
                string type = parts[0];

                if (type == "Car")
                {
                    string brand = parts[1];
                    string model = parts[2];
                    int horsePower = int.Parse(parts[3]);

                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    catalogueVehicle.Cars.Add(car);
                }

                else
                {
                    string brand = parts[1];
                    string model = parts[2];
                    int weight = int.Parse(parts[3]);

                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    catalogueVehicle.Trucks.Add(truck);
                }
            }

            
            if (catalogueVehicle.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalogueVehicle.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                
            }

            if (catalogueVehicle.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalogueVehicle.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class CatalogVehicle
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public CatalogVehicle() // инициализация на Cars и Trucks листовете в конструктора
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
