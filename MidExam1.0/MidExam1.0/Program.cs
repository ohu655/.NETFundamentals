using System;

namespace MidExam1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            int maxBonus = 0;
            int maxAtendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int studentAtendances = int.Parse(Console.ReadLine());

                int totalBonus = (int)Math.Ceiling((double)studentAtendances / lecturesCount * (5 + initialBonus));

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAtendances = studentAtendances;

                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAtendances} lectures.");
        }
    }
}
