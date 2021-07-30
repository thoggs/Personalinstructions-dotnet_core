using System;
using Personalinstructions.NotificationContext;

namespace Personalinstructions.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
    
}