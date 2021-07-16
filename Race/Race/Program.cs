using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex namePattern = new Regex(@"([A-Za-z]+)");
            Regex kilometers = new Regex(@"\d");

            Dictionary<string, int> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of race")
                {
                    break;
                }

                MatchCollection letterMatches = namePattern.Matches(line);
                MatchCollection numberMatches = kilometers.Matches(line);

                string name = GetName(letterMatches);

                int sum = GetSum(numberMatches);

                if (!names.ContainsKey(name))
                {
                    continue;
                }

                names[name] += sum;

            }

            string[] winners = names
                .OrderByDescending(x => x.Value)
                .Take(3)
                .Select(x => x.Key)
                .ToArray();

           
                Console.WriteLine($"1st place: {winners[0]}");
                Console.WriteLine($"2nd place: {winners[1]}");
                Console.WriteLine($"3rd place: {winners[2]}");
            

        }

        private static int GetSum(MatchCollection matchCollection)
        {
            int sum = 0;

            foreach (Match match in matchCollection)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection matchCollection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matchCollection)
            {
                sb.Append(match);
            }

            return sb.ToString();
        }
    }
}
