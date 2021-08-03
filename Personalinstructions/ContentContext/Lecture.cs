using Personalinstructions.ContentContext.Enums;
using Personalinstructions.SharedContext;

namespace Personalinstructions.ContentContext
{
    public abstract class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}