﻿using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split();

            int rotations = int.Parse(Console.ReadLine());
            

            for (int j = 0; j < rotations; j++)
            {
                string firstElement = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    int prevIndex = i - 1;
                    array[prevIndex] = array[i];
                }

                array[array.Length - 1] = firstElement;
            }

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
