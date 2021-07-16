using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] array1 = new int[lines];
            int[] array2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                if (i % 2 != 0)
                {
                    array1[i] = secondNumber;
                    array2[i] = firstNumber;
                }
                else
                {
                    array1[i] = firstNumber;
                    array2[i] = secondNumber;
                }
            }
            Console.WriteLine( string.Join( " ",array1));
            Console.WriteLine( string.Join( " ",array2));
        }
    }
}
