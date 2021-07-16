using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] train = new int[number];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write($"{train[i]} ");
                sum += train[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
