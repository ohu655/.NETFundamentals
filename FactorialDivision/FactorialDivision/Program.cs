using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());

            double factorial1 = CalculateFactorial(number1);
            double factorial2 = CalculateFactorial(number2);

            double result = factorial1 / factorial2;

            Console.WriteLine($"{result:f2}");
        }

 

        private static double CalculateFactorial(double number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

    }
}
