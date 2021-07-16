using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;

            switch (symbol)
            {
                case "+":
                  result = Plus(num1, num2);
                    Console.WriteLine($"{result}");
                    break;

                case "-":
                   result = Minus(num1, num2);
                    Console.WriteLine($"{result}");
                    break;

                case "*":
                   result = Multiplication(num1, num2);
                    Console.WriteLine($"{result}");
                    break;

                case "/":
                   result = Division(num1, num2);
                    Console.WriteLine($"{result}");
                    break;
            }


        }

        static double Plus(double num1, double num2)
        {
            double result = 0;

            result = num1 + num2;

            return result;
        }

        static double Minus(double num1, double num2)
        {
            double result = 0;

            result = num1 - num2;

            return result;
        }

        static double Multiplication(double num1, double num2)
        {
            double result = 0;

            result = num1 * num2;

            return result;
        }

        static double Division(double num1, double num2)
        {
            double result = 0;

            result = num1 / num2;

            return result;
        }
    }
}
