using System;
using Personalinstructions.NotificationContext;
using Personalinstructions.SharedContext;

namespace Personalinstructions.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;

            if (course == null)
            {
                AddNotification(new Notification("Course", "Curso Invalido"));
            }
        }

        public int Order { get; }
        public string Title { get; }
        public string Description { get; }
        public Course Course { get; }
    }
}