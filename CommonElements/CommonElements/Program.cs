using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split();

            string[] array2 = Console.ReadLine()
                .Split();

            foreach (var secondElement in array2)
            {
                foreach (var firstElement in array1)
                {
                    if (secondElement == firstElement)
                    {
                        Console.Write($"{firstElement} ");
                    }
                }
            }
        }
    }
}
