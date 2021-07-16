using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            int result = MultiplyWords(words[0], words[1]);

            Console.WriteLine(result);
        }

        private static int MultiplyWords(string first, string second)
        {
            int minLenght = Math.Min(first.Length, second.Length);

            int sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                sum += SumRemainingCharacters(first, minLenght);
            }
            else if (second.Length > first.Length)
            {
                sum += SumRemainingCharacters(second, minLenght);
            }

            return sum;
        }

        private static int SumRemainingCharacters(string word, int idx)
        {
            int sum = 0;

            for (int i = idx; i < word.Length; i++)
            {
                sum += word[i];
            }

            return sum;
        }
    }
}
