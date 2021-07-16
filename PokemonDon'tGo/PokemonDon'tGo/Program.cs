using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

             List<double> result = new List<double>();


            while (true)
            {
                if (numbers.Count == 0)
                {
                    break;
                }

                int idx = int.Parse(Console.ReadLine());
                

                if (idx < 0)
                {
                    idx = 0;
                    int thisNumber = numbers[idx];
                    result.Add(thisNumber);
                    numbers[0] = numbers[numbers.Count - 1];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > thisNumber)
                        {
                            numbers[i] -= thisNumber;
                        }

                        else if (numbers[i] <= thisNumber)
                        {
                            numbers[i] += thisNumber;
                        }
                    }
                }

                else if (idx >= numbers.Count)
                {
                   
                    int lastNumber = numbers[numbers.Count - 1];
                    result.Add(lastNumber);
                    numbers[numbers.Count - 1] = numbers[0];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > lastNumber)
                        {
                            numbers[i] -= lastNumber;
                        }

                        else if (numbers[i] <= lastNumber)
                        {
                            numbers[i] += lastNumber;
                        }
                    }
                }

                else
                {
                    int currentnumber = numbers[idx];
                    result.Add(currentnumber);
                    numbers.Remove(currentnumber);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > currentnumber)
                        {
                            numbers[i] -= currentnumber;
                        }

                        else if (numbers[i] <= currentnumber)
                        {
                            numbers[i] += currentnumber;
                        }
                    }
                }
                
            }

            double sum = 0;

            foreach (var number in result)
            {
                sum += number;
           }

            Console.WriteLine(sum);
        }
    }
}
