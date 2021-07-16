using System;
using System.Linq;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);
       
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int multiply = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            
            return multiply;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int result = 0;

            while (number !=0)
            {
                int nextNumber = number % 10;

                if (nextNumber %2 ==0)
                {
                    result += nextNumber;
                }

                number -= nextNumber;
                number /= 10;
            }

            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            int result = 0;

            while (number != 0)
            {
                int nextNumber = number % 10;

                if (nextNumber % 2 == 1)
                {
                    result += nextNumber;
                }

                number -= nextNumber;
                number /= 10;
            }

            return result;
        }
    }
}
