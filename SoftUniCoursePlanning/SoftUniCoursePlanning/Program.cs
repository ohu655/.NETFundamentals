using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "course start")
                {
                    break;
                }

                string[] parts = line.Split(":");
                string command = parts[0];

                if (command == "Add")
                {
                    string lessonTitle = parts[1];

                    if (!courses.Contains(lessonTitle))
                    {
                        courses.Add(lessonTitle);
                    }
                }

                else if (command == "Insert")
                {
                    string lessonTitle = parts[1];
                    int idx = int.Parse(parts[2]);

                    if (!courses.Contains(lessonTitle))
                    {
                        courses.Insert(idx, lessonTitle);
                    }
                }

                else if (command == "Remove")
                {
                    string lessonTitle = parts[1];

                    if (courses.Contains(lessonTitle))
                    {
                        courses.Remove(lessonTitle);
                    }

                    if (courses.Contains(lessonTitle + "-Exercise"))
                    {
                        int idx = courses.IndexOf(lessonTitle + "-Exercise");
                        courses.RemoveAt(idx);
                    }
                }

                else if (command == "Swap")
                {
                    string lessonTitle1 = parts[1];
                    string lessonTitle2 = parts[2];

                    if (courses.Contains(lessonTitle1) && courses.Contains(lessonTitle2))
                    {

                        int idx1 = courses.IndexOf(lessonTitle1);
                        int idx2 = courses.IndexOf(lessonTitle2);

                        courses.RemoveAt(idx1);
                        courses.Insert(idx1, lessonTitle2);
                        courses.RemoveAt(idx2);
                        courses.Insert(idx2, lessonTitle1);

                        if (courses.Contains(lessonTitle1 + "-Exercise"))
                        {
                            int exerciseIdx = courses.IndexOf(lessonTitle1 + "-Exercise");
                            courses.RemoveAt(exerciseIdx);
                            courses.Insert(idx2 + 1, lessonTitle1 + "-Exercise");

                        }

                        if (courses.Contains(lessonTitle2 + "-Exercise"))
                        {
                            int exerciseIdx = courses.IndexOf(lessonTitle2 + "-Exercise");
                            courses.RemoveAt(exerciseIdx);
                            courses.Insert(idx1 + 1, lessonTitle2 + "-Exercise");

                        }
                    }
                }

                else if (command == "Exercise")
                {
                    string lessonTitle = parts[1];

                    if (courses.Contains(lessonTitle))
                    {
                        if (!courses.Contains(lessonTitle + "-Exercise"))
                        {
                            int idx = courses.IndexOf(lessonTitle);
                            courses.Insert(idx + 1, lessonTitle + "-Exercise");
                        }
                    }

                    else if (!courses.Contains(lessonTitle))
                    {
                        courses.Add(lessonTitle);
                        courses.Add(lessonTitle + "-Exercise");
                    }
                }
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }

        }
    }
}
