using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < firstPlayer.Count; i++)
            {
                
                if (firstPlayer[i] > secondPlayer[i])
                {
                    firstPlayer.Add(firstPlayer[i]);
                    firstPlayer.Add(secondPlayer[i]);
                    firstPlayer.Remove(firstPlayer[i]);
                    secondPlayer.Remove(secondPlayer[i]);
                }

                else if (secondPlayer[i] > firstPlayer[i])
                {
                    secondPlayer.Add(secondPlayer[i]);
                    secondPlayer.Add(firstPlayer[i]);
                    secondPlayer.Remove(secondPlayer[i]);
                    firstPlayer.Remove(firstPlayer[i]);
                }

                else if (firstPlayer[i] == secondPlayer[i])
                {
                    firstPlayer.Remove(firstPlayer[i]);
                    secondPlayer.Remove(secondPlayer[i]);
                }

                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }

                i = -1;
            }

            int result = 0;

            if (firstPlayer.Count == 0)
            {
                foreach (var number in secondPlayer)
                {
                    result += number;
                }

                Console.WriteLine($"Second player wins! Sum: {result}");
            }

            else
            {
                foreach (var number in firstPlayer)
                {
                    result += number;
                }

                Console.WriteLine($"First player wins! Sum: {result}");
            }
      
        }
    }
}
