using System;
using System.Linq;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Generate")
                {
                    break;
                }

                string[] parts = line.Split(">>>");
                string command = parts[0];

                if (command == "Contains")
                {
                    string subString = parts[1];

                    if (rawKey.Contains(subString))
                    {
                        Console.WriteLine($"{rawKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    string subCommand = parts[1];
                    int startIndex = int.Parse(parts[2]);
                    int endIndex = int.Parse(parts[3]);

                    if (subCommand == "Upper")
                    {
                        int symbolsToReplace = endIndex - startIndex;
                        string substring = rawKey.Substring(startIndex, symbolsToReplace);
                        string upperSubstring = rawKey.Substring(startIndex, symbolsToReplace).ToUpper();

                        rawKey = rawKey.Replace(substring, upperSubstring);
                        Console.WriteLine(rawKey);
                    }
                    else if (subCommand == "Lower")
                    {
                        int symbolsToReplace = endIndex - startIndex;
                        string substring = rawKey.Substring(startIndex, symbolsToReplace);
                        string lowerSubstring = rawKey.Substring(startIndex, symbolsToReplace).ToLower();

                        rawKey = rawKey.Replace(substring, lowerSubstring);
                        Console.WriteLine(rawKey);
                    }
                }

                else if (command == "Slice")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    int symbolsToRemove = endIndex - startIndex;

                    rawKey = rawKey.Remove(startIndex, symbolsToRemove);

                    Console.WriteLine(rawKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
