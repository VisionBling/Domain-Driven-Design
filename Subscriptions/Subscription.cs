using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Subscriptions
{
    public class Subscription
    {
       public int SubscriptionID { get; set; }
       public string SubscriptionName { get; set; }

        public string SubscriptionType { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
