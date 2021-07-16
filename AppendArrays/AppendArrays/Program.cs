using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    if (startIndex >= input.Count)
                    {
                        continue;
                    }

                    if (endIndex < 0)
                    {
                        continue;
                    }
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count -1;
                    }

                    string merged = "";

                    for (int i = startIndex; i <= endIndex ; i++)
                    {
                        string currentElement = input[i];

                        merged += currentElement;
                    }

                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, merged);
                }

                else if (command == "divide")
                {
                    int index = int.Parse(parts[1]);
                    int partitions = int.Parse(parts[2]);

                    string element = input[index];

                    input.RemoveAt(index);

                    int partitionSize = element.Length / partitions;

                    List<string> substrings = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string substring = element.Substring(i * partitionSize, partitionSize);

                        substrings.Add(substring);
                    }

                    string lastSubstring = element.Substring((partitions - 1) * partitionSize);
                    substrings.Add(lastSubstring);

                    input.InsertRange(index, substrings);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
