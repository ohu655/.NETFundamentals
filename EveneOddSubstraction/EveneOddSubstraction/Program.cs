using System;
using System.Linq;

namespace EveneOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int evenCounter = 0;
            int oddCounter = 0;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCounter += arr[i];
                }
                else
                {
                    oddCounter += arr[i];
                }
            }
            result = evenCounter - oddCounter;
            Console.WriteLine(result);
        }
    }
}
