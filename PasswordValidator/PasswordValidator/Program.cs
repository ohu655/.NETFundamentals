using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passwordChecker = true;

            if (!IsCharactersTrue(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                passwordChecker = false;
            }

            if (IsContainsIvanlidCharacters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                passwordChecker = false;
            }

            if (!IsContaintsTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                passwordChecker = false;
            }

            if (passwordChecker)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool IsContaintsTwoDigits(string password)
        {
            int counter = 0;
            foreach (var element in password)
            {
                if (char.IsDigit(element))
                {
                    counter += 1;
                }

                if (counter == 2)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsCharactersTrue(string password)
        {
   
            if (password.Length >= 6 && password.Length <= 10 )
            {
                return true;
            }

            return false;
        }

        private static bool IsContainsIvanlidCharacters(string password)
        {
            foreach (var element in password)
            {
                if (!char.IsLetterOrDigit(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
