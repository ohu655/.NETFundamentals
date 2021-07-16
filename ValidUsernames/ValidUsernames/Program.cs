using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            return IsValidCharacters(username) && IsValidLenght(username);
        }

        private static bool IsValidCharacters(string username)
        {
            foreach (char element in username)
            {
                if (!char.IsLetterOrDigit(element)
                    && element != '-' 
                    && element != '_')
                {
                    return false;
                }
                
            }
            return true;
        }

        private static bool IsValidLenght(string username)
        {
            return username.Length >= 3 && username.Length <= 16;
        }
    }
}
