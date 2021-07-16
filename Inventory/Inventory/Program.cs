using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Craft!")
                {
                    break;
                }

                string[] parts = line.Split(" - ");
                string command = parts[0];

                if (command == "Collect")
                {
                    string item = parts[1];

                    if (IsItemExist(inventory, item))
                    {
                        continue;
                    }

                    inventory.Add(item);
                }

                else if (command == "Drop")
                {
                    string item = parts[1];

                    if (!IsItemExist(inventory, item))
                    {
                        continue;
                    }

                    inventory.Remove(item);
                }

                else if (command == "Combine Items")
                {
                    string[] item = parts[1].Split(":");
                    string oldItem = item[0];
                    string newItem = item[1];

                    if (!IsItemExist(inventory, oldItem))
                    {
                        continue;
                    }

                    for (int i = 0; i < inventory.Count; i++)
                    {
                        string currentItem = inventory[i];
                        int currentIndex = inventory.IndexOf(currentItem);

                        if (currentItem == oldItem)
                        {
                            inventory.Insert(currentIndex + 1, newItem);
                        }
                    }
                }

                else if (command == "Renew")
                {
                    string item = parts[1];

                    if (!IsItemExist(inventory, item))
                    {
                        continue;
                    }

                    inventory.Remove(item);
                    inventory.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
                
        }

        private static bool IsItemExist(List<string> inventory, string item)
        {
            foreach (var element in inventory)
            {
                if (element == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
