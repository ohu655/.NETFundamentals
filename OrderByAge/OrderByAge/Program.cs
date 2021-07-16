using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{

    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                string name = parts[0];
                string id = parts[1];
                int age = int.Parse(parts[2]);

                Person person = new Person
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                persons.Add(person);
            }

            List<Person> sorted = persons
                .OrderBy(n => n.Age)
                .ToList();

            foreach (Person person in sorted)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
