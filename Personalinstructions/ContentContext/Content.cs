using System;

namespace Personalinstructions.ContentContext
{
    public class Content : Base
    {
        protected Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        
        public string Title { get; }
        public string Url { get; }
    }
}