using System;
using System.Collections.Generic;
using System.Linq;

namespace Train_List_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Add")
                {
                    int passengers = int.Parse(parts[1]);

                    wagons.Add(passengers);
                }

                else
                {
                    int passengers = int.Parse(parts[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
