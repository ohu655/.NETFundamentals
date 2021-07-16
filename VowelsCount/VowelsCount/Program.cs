using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int result = GetVolewsCount(word);

            Console.WriteLine(result);
        }

        private static int GetVolewsCount(string word)
        {
            int counter = 0;


            foreach (char element in word)
            {

                if (element == 'a')
                {
                    counter += 1;
                }

                if (element == 'e')
                {
                    counter += 1;
                }

                if (element == 'i')
                {
                    counter += 1;
                }

                if (element == 'o')
                {
                    counter += 1;
                }

                if (element == 'u')
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}
