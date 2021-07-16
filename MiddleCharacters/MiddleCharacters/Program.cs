using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = MiddleCharacters(input);

            Console.WriteLine(result);
        }

        private static string MiddleCharacters(string input)
        {
            
                if (input.Length % 2 == 0)
                {
                    return $"{input[input.Length / 2 - 1]}{input[input.Length / 2]}";
                }

                return $"{input[(input.Length - 1) / 2]}";
        }
    }
}
