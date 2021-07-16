using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> IDByCompany = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" -> ");
                string company = parts[0];
                string ID = parts[1];

                if (!IDByCompany.ContainsKey(company))
                {
                    IDByCompany.Add(company, new List<string>());
                }

                IDByCompany[company].Add(ID);

            }

            foreach (var company in IDByCompany)
            {
                Console.WriteLine($"{company.Key}");

                List<string> uniqueEmployees = company.Value
                    .Distinct()
                    .ToList();

                foreach (var employee in uniqueEmployees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
