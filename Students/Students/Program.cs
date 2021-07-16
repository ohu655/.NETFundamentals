using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                string firstName = parts[0];
                string lastName = parts[1];
                int age = int.Parse(parts[2]);
                string homeTown = parts[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);

            }

            string nameOfCity = Console.ReadLine();

            foreach ( Student student in students)
            {
                if (student.HomeTown == nameOfCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
