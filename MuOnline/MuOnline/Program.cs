using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] dungeon = Console.ReadLine()
                .Split("|");

            for (int i = 0; i < dungeon.Length; i++)
            {
                string[] room = dungeon[i].Split();

                if (room[0] == "potion")
                {

                    if (health + int.Parse(room[1]) > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {room[1]} hp.");
                        health += int.Parse(room[1]);
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (room[0] == "chest")
                {
                    Console.WriteLine($"You found {room[1]} bitcoins.");

                    bitcoins += int.Parse(room[1]);
                }

                else
                {
                    health -= int.Parse(room[1]);

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {room[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {room[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }

            if (health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
            
         
        }
    }
}
