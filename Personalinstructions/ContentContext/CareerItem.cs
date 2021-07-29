namespace Personalinstructions.ContentContext
{
    public class CareerItem
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; }
        public string Title { get; }
        public string Description { get; }
        public Course Course { get; }
    }
}