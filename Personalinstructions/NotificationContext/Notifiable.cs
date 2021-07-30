using System.Collections.Generic;
using System.Linq;

namespace Personalinstructions.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        protected Notifiable()
        {
            Notifications = new List<Notification>();
        }
        
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddRangeNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsInvalidNotification => Notifications.Any();

    }
}