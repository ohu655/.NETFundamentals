using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
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

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Add")
                {
                    int idx = int.Parse(parts[1]);

                    Add(numbers, idx);
                }

                else if (command == "Remove")
                {
                    int idx = int.Parse(parts[1]);

                    Remove(numbers, idx);
                }

                else if (command == "RemoveAt")
                {
                    int idx = int.Parse(parts[1]);

                    RemoveAt(numbers, idx);
                }

                else if (command == "Insert")
                {
                    int number = int.Parse(parts[1]);
                    int idx = int.Parse(parts[2]);

                    Insert(numbers,number, idx);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Insert(List<int> numbers, int number, int idx)
        {
            numbers.Insert(idx, number); 
        }

        private static void RemoveAt(List<int> numbers, int idx)
        {
            numbers.RemoveAt(idx);
        }

        private static void Remove(List<int> numbers, int idx)
        {
            numbers.Remove(idx);
        }

        private static void Add(List<int> numbers, int idx)
        {
            numbers.Add(idx);
        }
    }
}
