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

            string command = "";

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                command = parts[0];

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

                    Insert(numbers, number, idx);
                }

                else if (command == "Contains")
                {
                    int idx = int.Parse(parts[1]);

                    Contains(numbers, idx);
                }

                else if (command == "PrintEven")
                {

                   List<int> result = PrintEven(numbers);

                   Console.WriteLine(string.Join(" ", result));

                }

                else if (command == "PrintOdd")
                {

                    List<int> result = PrintOdd(numbers);

                    Console.WriteLine(string.Join(" ", result));

                }

                else if (command == "GetSum")
                {

                  int result = GetSum(numbers);

                    Console.WriteLine(result);

                }

                else if (command == "Filter")
                {
                    string condition = parts[1];
                    int number = int.Parse(parts[2]);

                    List<int> result = Filter(numbers, condition, number);

                    Console.WriteLine(string.Join(" ", result));

                }
            }

            switch (command)
            {
                case "Add":
                case "Remove":
                case "RemoveAt":
                case "Insert":

                    Console.WriteLine(string.Join(" ", numbers));

                    break;
            }
           
        }

        private static List<int> Filter(List<int> numbers, string condition, int number)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (condition)
                {
                    case "<":
                        if (numbers[i] < number)
                        {
                            result.Add(numbers[i]);
                        }

                    break;

                    case ">":
                        if (numbers[i] > number)
                        {
                            result.Add(numbers[i]);
                        }

                    break;

                    case ">=":
                        if (numbers[i] >= number)
                        {
                            result.Add(numbers[i]);
                        }

                    break;

                    case "<=":
                        if (numbers[i] <= number)
                        {
                            result.Add(numbers[i]);
                        }

                    break;

                }
            }

            return result;
        }

        private static int GetSum(List<int> numbers)
        {

            int result = numbers.Sum();

            return result;
        }

        private static List<int> PrintOdd(List<int> numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }

        private static List<int> PrintEven(List<int> numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }

            return result;           
        }

        private static void Contains(List<int> numbers, int idx)
        {
            numbers.Contains(idx);

            if (numbers.Contains(idx))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
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
