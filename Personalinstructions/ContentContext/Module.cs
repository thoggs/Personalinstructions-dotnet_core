using System.Collections.Generic;
using Personalinstructions.SharedContext;

namespace Personalinstructions.ContentContext
{
    public abstract class Module : Base
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