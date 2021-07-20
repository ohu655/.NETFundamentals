using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex barcodePattern = new Regex(@"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+");
            Regex numbersPattern = new Regex(@"(?<numbers>\d+)");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               string barcode = Console.ReadLine();

                Match match = barcodePattern.Match(barcode);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                
                    MatchCollection matchNumber = numbersPattern.Matches(barcode);

                    if (matchNumber.Count < 1)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        string number = GetNumber(matchNumber);

                        Console.WriteLine($"Product group: {number}");
                    }
                   
                    
                }
            }
        }

        private static string GetNumber(MatchCollection matchCollection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matchCollection)
            {
                sb.Append(match);
            }

            return sb.ToString();
        }
    }
}
