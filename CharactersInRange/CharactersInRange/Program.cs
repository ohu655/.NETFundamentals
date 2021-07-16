using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstElement = char.Parse(Console.ReadLine());
            char secondElement = char.Parse(Console.ReadLine());

            GetElementsBetween(firstElement, secondElement);
        }

        private static void GetElementsBetween(char firstElement, char secondElement)
        {
            if (firstElement > secondElement)
            {
                for (char i =(char)(secondElement + 1); i < firstElement; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                for (char i = (char)(firstElement + 1); i < secondElement; i++)
                {
                    Console.Write($"{i} ");
                }
            }  
        }
    }
}
