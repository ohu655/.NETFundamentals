using System;
using System.Collections.Generic;

namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registerPlates = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0];

                if (command == "register")
                {
                    string username = line[1];
                    string plateNumber = line[2];

                    if (registerPlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        registerPlates.Add(username, plateNumber);
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                }
                else
                {
                    string username = line[1];

                    if (!registerPlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registerPlates.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in registerPlates)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
