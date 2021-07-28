using System;
using System.Collections.Generic;
using Personalinstructions.ContentContext;

namespace Personalinstructions
{
    internal static class Program
    {
        private static void Main()
        {
            var articles = new List<Article>
            {
                new("Artigo Sobre OOP", "https://google.com"),
                new("Artigo Sobre C#", "https://google.com"),
                new("Artigo Sobre .NET Core", "https://google.com")
            };
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}