using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] condensed = new int[arr.Length - 1];

            while (arr.Length > 1)
            {
               
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                    arr[i] = condensed[i];
                }

                Array.Resize(ref condensed, condensed.Length - 1);
                Array.Resize(ref arr, arr.Length - 1);
            }

            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
