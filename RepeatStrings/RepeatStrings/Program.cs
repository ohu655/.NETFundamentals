using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (var element in input)
            {
                for (int i = 0; i < element.Length; i++)
                {
                    result += element;
                }
            }

            Console.WriteLine(result);
        }
    }
}
