using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> gradeByStudent = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeByStudent.ContainsKey(studentName))
                {
                    gradeByStudent.Add(studentName, new List<double>());
                }

                gradeByStudent[studentName].Add(grade);
            }

            Dictionary<string, List<double>> sortedStudents = gradeByStudent
                .Where(s => s.Value.Average() >= 4.5)
                .OrderByDescending(s => s.Value.Average())
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var kvp in sortedStudents)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
