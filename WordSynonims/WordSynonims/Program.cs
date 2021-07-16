using System;
using System.Collections.Generic;

namespace WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());

                }

                words[word].Add(synonim);
            }

            foreach (var element in words)
            {
                Console.WriteLine($"{element.Key} - {string.Join(", ", element.Value)}");
            }
        }
    }
}
