using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> pointByUsername = new Dictionary<string, int>();
            Dictionary<string, List<string>> usernamesByLanguage = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] parts = line.Split("-");
                string userName = parts[0];

                if (line.Contains("banned"))
                {
                    string command = parts[1];

                    pointByUsername.Remove(userName);
                }
                else
                {
                    string language = parts[1];
                    int points = int.Parse(parts[2]);

                    if (!pointByUsername.ContainsKey(userName))
                    {
                        pointByUsername.Add(userName, points);
                    }

                    if (pointByUsername[userName] <= points)
                    {
                        pointByUsername[userName] = points;
                    }



                    if (!usernamesByLanguage.ContainsKey(language))
                    {
                        usernamesByLanguage.Add(language, new List<string>());
                    }

                    usernamesByLanguage[language].Add(userName);
                }
            }


            Console.WriteLine("Results:");

            Dictionary<string, int> sortedPoints = pointByUsername
                .OrderByDescending(n => n.Value)
                .ThenBy(n => n.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedPoints)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            Dictionary<string, List<string>> sortedLanguage = usernamesByLanguage
                .OrderByDescending(n => n.Value.Count)
                .ThenBy(n => n.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedLanguage)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Count}");
            }
        }
    }
}
