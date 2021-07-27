using System.Collections.Generic;

namespace Personalinstructions.ContentContext
{
    public abstract class Module
    {
        protected Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        private IList<Lecture> Lectures { get; set; }
    }
}