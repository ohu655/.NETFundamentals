using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex regex = new Regex(@">>(?<item>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");

            double totalIncome = 0;
            List<string> items = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["item"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                double quantity = double.Parse(match.Groups["quantity"].Value);

                items.Add(name);

                totalIncome += price * quantity;

                
            }

            Console.WriteLine("Bought furniture:");

            foreach (var element in items)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"Total money spend: {totalIncome:f2}");
        }
    }
}
