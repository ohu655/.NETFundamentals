using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split(" : ");
                string courseName = parts[0];
                string studentName = parts[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);
            }

            Dictionary<string, List<string>> sortedCourses = courses
                .OrderByDescending(n => n.Value.Count)
                .ToDictionary(n => n.Key, n => n.Value);



            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
                
        }
    }
}
