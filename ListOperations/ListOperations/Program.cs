using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Add")
                {
                    int number = int.Parse(parts[1]);

                    numbers.Add(number);
                }

                else if (command == "Insert")
                {
                    int number = int.Parse(parts[1]);
                    int idx = int.Parse(parts[2]);

                    if (idx > numbers.Count || idx < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(idx, number);
                }

                else if (command == "Remove")
                {
                    int idx = int.Parse(parts[1]);

                    if (idx >= numbers.Count || idx < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(idx);
                }

                else if (command == "Shift")
                {
                    string direction = parts[1];
                    int count = int.Parse(parts[2]);

                    if (direction == "left")
                    {
 
                        for (int i = 0; i < count; i++)
                        {
                            int currentNumber = numbers[0];

                            numbers.RemoveAt(0);
                            numbers.Add(currentNumber);  
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];

                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNumber);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
