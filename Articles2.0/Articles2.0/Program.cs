using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


     
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ");


                Article article = new Article
                {
                    Title = articleData[0],
                    Content = articleData[1],
                    Author = articleData[2]
                };

                articles.Add(article);
            }

            string command = Console.ReadLine();

            List<Article> sorted = new List<Article>();

            if (command == "title")
            {
                sorted = articles.OrderBy(x => x.Title).ToList();

            }

            else if (command == "content")
            {
                sorted = articles.OrderBy(x => x.Content).ToList();
            }

            else
            {
                sorted = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (Article element in sorted)
            {
                Console.WriteLine($"{element.Title} - {element.Content}: {element.Author}");
            }
        }
    }
}
