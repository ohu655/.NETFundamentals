using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");

            string lastElement = path[path.Length - 1];

            string[] fileParts = lastElement.Split(".");

            string extension = fileParts[fileParts.Length - 1];

            string fileName = lastElement.Replace($".{extension}", "");

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
