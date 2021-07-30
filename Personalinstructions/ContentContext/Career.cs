using System.Collections.Generic;

namespace Personalinstructions.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; }

        public int TotalCourses => Items.Count;
    }
}