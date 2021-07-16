using System;
using System.Text;

namespace CaesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char element in text)
            {
                char cryptedElement = (char)(element + 3);
                sb.Append(cryptedElement);
            }

            Console.WriteLine(sb);

        }
    }
}
