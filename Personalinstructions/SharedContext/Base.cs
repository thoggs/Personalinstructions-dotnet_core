using System;
using Personalinstructions.NotificationContext;

namespace Personalinstructions.SharedContext
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