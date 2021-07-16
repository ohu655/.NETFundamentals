using System;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int reminder = 0;

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            List<string> result = new List<string>();

            for (int i = numbers.Length -1; i >= 0; i--)
            {
                int digit = numbers[i] -'0';

                reminder += multiplier * digit;

                if (reminder > 9)
                {
                    int reminderLastDigit = reminder % 10;
                    reminder /= 10;

                    result.Add(reminderLastDigit.ToString());
                }
                else
                {
                    result.Add(reminder.ToString());
                    reminder = 0;
                }
            }

            if (reminder > 0)
            {
                result.Add(reminder.ToString());
            }

            result.Reverse();

            Console.WriteLine(string.Concat(result));
        }
    }
}
