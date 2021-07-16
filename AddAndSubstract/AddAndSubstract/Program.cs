using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int result = Sum(number1, number2, number3);

            Console.WriteLine(result);
        }

 
        private static int Sum(int number1, int number2, int number3)
        {
            return  (number1 + number2) - number3;
        }
    }
}
