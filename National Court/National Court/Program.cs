using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdtEmployee = int.Parse(Console.ReadLine());

            double customers = double.Parse(Console.ReadLine());

            int peoplePerHour = firstEmployee + secondEmployee + thirdtEmployee;

            double totalHours = customers / peoplePerHour;
            totalHours = Math.Ceiling(totalHours);

            for (int i = 1; i <= totalHours; i++)
            {
                int currentNumber = i;

                if (i % 4 == 0)
                {
                    totalHours += 1;
                }

            }

            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
