using System;
using System.Text.RegularExpressions;

namespace SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[^|$%.]*%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)[^|$%.]*\$");
            double totalIncome = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of shift")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string customer = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                double totalPrice = price * count;
                totalIncome += price * count;

                Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
