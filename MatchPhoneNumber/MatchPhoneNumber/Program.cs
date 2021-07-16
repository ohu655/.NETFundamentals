using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([+][359]+[\s]+[2]+[\s]+\d{3}[\s]+\d{4})|([+][359]+[-]+[2]+[-]+\d{3}[-]+\d{4})";

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ", matchedPhones));
        }
    }
}
