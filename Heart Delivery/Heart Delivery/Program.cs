using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            int currentIndex = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Love!")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];
                int jump = int.Parse(parts[1]);
                currentIndex += jump;

                if (currentIndex >= houses.Count)
                {
                    currentIndex = 0;
                }

                if (houses[currentIndex] != 0)
                {
                    houses[currentIndex] -= 2;

                    if (houses[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }   
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            bool isSuccesfull = true;

            foreach (var element in houses)
            {
                if (element != 0)
                {
                    isSuccesfull = false;
                    break;
                }
            }

            int count = 0;

            foreach (var element in houses)
            {
                if (element != 0)
                {
                    count++;
                }
            }

            if (isSuccesfull)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
