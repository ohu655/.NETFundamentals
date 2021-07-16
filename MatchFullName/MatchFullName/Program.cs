using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\b[A-Z][a-z]+ [A-Z][a-z]+\b)";

            string names = Console.ReadLine();

            MatchCollection matchedName = Regex.Matches(names, pattern);

            foreach (Match name in matchedName)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
