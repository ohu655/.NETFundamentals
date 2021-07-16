using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bestSequenceSize = 0;
            int bestSequenceNunber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int sequenceSize = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];

                    if (currentNumber == rightNumber)
                    {
                        sequenceSize += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceSize > bestSequenceSize)
                {
                    bestSequenceSize = sequenceSize;
                    bestSequenceNunber = currentNumber;
                }
            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNunber} ");
            }

            Console.WriteLine();
        }
    }
}
