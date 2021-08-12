using System;
using System.Linq;
using System.Collections.Generic;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Sail")
                {
                    break;
                }

                string[] parts = line.Split("||");
                string name = parts[0];
                int population = int.Parse(parts[1]);
                int gold = int.Parse(parts[2]);

                if (cities.ContainsKey(name))
                {
                    cities[name][0] += population;
                    cities[name][1] += gold;
                }
                else
                {
                    cities.Add(name, new List<int>() { population, gold });
                }

            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split("=>");
                string command = parts[0];
                string town = parts[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(parts[2]);
                    int gold = int.Parse(parts[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities.ContainsKey(town))
                    {
                        cities[town][0] -= people;

                        if (cities[town][0] <= 0)
                        {
                            cities.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                            continue;
                        }

                        cities[town][1] -= gold;

                        if (cities[town][1] <= 0)
                        {
                            cities.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                    }
                }

                else if (command == "Prosper")
                {
                    int gold = int.Parse(parts[2]);

                    if (cities.ContainsKey(town))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }

                        cities[town][1] += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                }
            }

            Dictionary<string, List<int>> sorted = cities
                .OrderByDescending(n => n.Value[1])
                .ThenBy(n => n.Key)
                .ToDictionary(n => n.Key, n => n.Value);

            if (sorted.Count <= 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {sorted.Count} wealthy settlements to go to:");

                foreach (var kvp in sorted)
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value[0]} citizens, Gold: {kvp.Value[1]} kg");
                }
            }
            

           

        }
    }
}
