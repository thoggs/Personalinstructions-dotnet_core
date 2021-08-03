using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Personalinstructions.NotificationContext;
using Personalinstructions.SharedContext;

namespace Personalinstructions.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (Ispremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já tem uma assinatura ativa"));
                return;
            }
            
            Subscriptions.Add(subscription);
        }
        public bool Ispremium => Subscriptions.Any(x => !x.IsInactive);
    }
}