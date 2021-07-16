using System;
using System.Collections.Generic;

namespace CountCharsinString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == ' ')
                {
                    continue;
                }

                if (symbols.ContainsKey(symbol))
                {
                    symbols[symbol]++;
                }

                else
                {
                    symbols.Add(symbol, 1);
                }
            }

            foreach (var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
