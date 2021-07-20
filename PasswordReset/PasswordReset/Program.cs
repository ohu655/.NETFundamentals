using System;
using System.Text;
using System.Linq;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Done")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "TakeOdd")
                {
                    password = TakeOdd(password);
                    Console.WriteLine(password); 
                }

                else if (command == "Cut")
                {
                    int index = int.Parse(parts[1]);
                    int lenght = int.Parse(parts[2]);

                    password = password.Remove(index, lenght);

                    Console.WriteLine(password);

                }

                else if (command == "Substitute")
                {
                    string substring = parts[1];
                    string substitute = parts[2];

                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }


        private static string TakeOdd(string password)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < password.Length; i+=2)
            {
                char element = password[i];
                sb.Append(element);
            }

            return sb.ToString();
        }
    }
}
