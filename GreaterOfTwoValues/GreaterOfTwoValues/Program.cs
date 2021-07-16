using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int showInt = GetMaxInt(firstInt, secondInt);

                    Console.WriteLine(showInt);
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char showChar = GetMaxChar(firstChar, secondChar);

                    Console.WriteLine(showChar);
                    break;

                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string showString = GetMaxString(firstString, secondString);

                    Console.WriteLine(showString);
                    break;
            }
            
        }


        static int GetMaxInt(int firstInt , int secondInt)
        {
            int result = 0;

            if (firstInt > secondInt)
            {
                result = firstInt;
            }
            else if (secondInt > firstInt)
            {
                result = secondInt;
            }

            return result;
        }

        static char GetMaxChar(char firstChar, char secondChar)
        {
            char result = '.';

            if (firstChar > secondChar)
            {
                result = firstChar;
            }
            else if (secondChar > firstChar)
            {
                result = secondChar;
            }

            return result;
        }

         static string GetMaxString(string firstString, string secondString)
        {
            string result = "";

            int comparison = firstString.CompareTo(secondString);
            if (comparison > 0)
            {
                result = firstString;
            }
            else
            {
                result = secondString;
            }
            return result;
        }
    }
}
