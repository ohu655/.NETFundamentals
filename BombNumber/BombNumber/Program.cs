using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            while (true)
            {
                int idx = numbers.IndexOf(bombNumber);

                if (idx == -1)
                {
                    break;
                }

                int startIndex = idx - bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int count = 2 * bombPower + 1;

                if (count > numbers.Count - startIndex)
                {
                    count = numbers.Count - startIndex;
                }

                numbers.RemoveRange(startIndex, count);
            }

            int result = 0; 

            foreach (var number in numbers)
            {
                 result += number;         
            }

            Console.WriteLine(result);

        }
    }
}
