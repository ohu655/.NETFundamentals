using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>(firstLine.Count + secondLine.Count);

            int limit = Math.Min(firstLine.Count, secondLine.Count);

            for (int i = 0; i < limit; i++)
            {
                result.Add(firstLine[i]);
                result.Add(secondLine[i]);
            }

            if (firstLine.Count != secondLine.Count)
            {
                if (firstLine.Count > secondLine.Count)
                {
                   result.AddRange(GetRemainingIndexes(firstLine, secondLine));
                }
                else
                {
                    result.AddRange(GetRemainingIndexes(secondLine, firstLine));
                }
            }

            Console.WriteLine(string.Join(" ", result));
                
        }

        private static List<int> GetRemainingIndexes(List<int> longerList, List<int> shorterList)
        {
            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            return result;
        }
    }
}
