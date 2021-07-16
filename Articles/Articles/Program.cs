﻿using System;

namespace Articles
{

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ");

            Article article = new Article
            {
                Title = articleData[0],
                Content = articleData[1],
                Author = articleData[2]  
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split(": ");
                string command = commandParts[0];
                string argument = commandParts[1];

                if (command == "Edit")
                {
                    article.Edit(argument);   
                }

                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }

                else
                {
                    article.Rename(argument);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
