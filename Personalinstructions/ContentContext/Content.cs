using System;

namespace Personalinstructions.ContentContext
{
    public class Content
    {
        protected Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }

        public Guid Id { get; }
        public string Title { get; }
        public string Url { get; }
    }
}