using System;

namespace Substirngs
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            int index = secondWord.IndexOf(firstWord);
            string result = secondWord.Remove(index, firstWord.Length);
            index = result.IndexOf(firstWord);

            while (index != -1)
            {
               
                result = result.Remove(index, firstWord.Length);
                index = result.IndexOf(firstWord);
            }

            Console.WriteLine(result);
        }
    }
}
