using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Personalinstructions.ContentContext.Enums;

namespace Personalinstructions.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public int DurationInMinutes { get; set; }
        private IList<Module> Modules { get; set; }
        public EContentLevel Level { get; set; }
    }
}