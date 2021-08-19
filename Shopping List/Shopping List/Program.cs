using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Go Shopping!")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Urgent")
                {
                    string item = parts[1];

                    if (shoppingList.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    string item = parts[1];

                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Correct")
                {
                    string oldItem = parts[1];
                    string newItem = parts[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        int index = shoppingList.IndexOf(oldItem);
                        shoppingList.Insert(index, newItem);
                        shoppingList.Remove(oldItem);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Rearrange")
                {
                    string item = parts[1];

                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
