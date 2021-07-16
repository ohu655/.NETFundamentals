using System;
using System.Collections.Generic;
using System.Linq;

namespace Students.Objects
{

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                Student student = new Student
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grade = double.Parse(input[2])
                };

                students.Add(student);
            }

            List<Student> sorted = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in sorted)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
