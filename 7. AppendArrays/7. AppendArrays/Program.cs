﻿using System;
using System.Collections.Generic;

namespace _7._AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|');

            List<string> result = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] element = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                result.AddRange(element);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
