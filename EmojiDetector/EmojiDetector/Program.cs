using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(:{2}(?<emoji>[A-Z][a-z]{2,}):{2})|(\*{2}([A-Z][a-z]+)\*{2})");

            List<string> emojis = new List<string>();

            string input = Console.ReadLine();

            long coolness = 1;

            for (int i = 0; i < input.Length; i++)
            {
                char element = input[i];

                if (char.IsDigit(element))
                {
                    int number = (int)(element - '0');
                    coolness *= number;
                }
            }

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                string emojiNames = match.Value;
                emojis.Add(emojiNames);
            }

            Console.WriteLine($"Cool threshold: {coolness}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            for (int i = 0; i < emojis.Count; i++)
            {
                string element = emojis[i];
                long result = 0;

                for (int j = 2; j < element.Length - 2; j++)
                {
                    char symbol = element[j];
                    
                    result += symbol;               
                }

                if (result > coolness)
                {
                    Console.WriteLine(element);
                }
            }
            
        }
    }
}
