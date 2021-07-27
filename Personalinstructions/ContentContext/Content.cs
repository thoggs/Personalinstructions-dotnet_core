using System;

namespace Personalinstructions.ContentContext
{
    public abstract class Content
    {
        protected Content()
        {
            Id = Guid.NewGuid();
        }

        private Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}