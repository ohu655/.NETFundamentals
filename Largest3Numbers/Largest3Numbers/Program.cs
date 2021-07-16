using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n)
                .ToArray();
                

            for (int i = 0; i < sorted.Length; i++)
            {
                if (sorted.Length > 3)
                {
                    Console.Write(sorted[i] + " ");
                    if (i == 2)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write(sorted[i] + " ");
                }
                
            }
        }
    }
}
