using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.OrderAggregate.Event
{
    public class OrderCreatedEvent : DomainEvent
    {
        public OrderCreatedEvent(string aggregateId, Dictionary<string,string> body) : base(aggregateId, body){}
        
        public override string Name()
        {
            return "order_created";
        }

        protected override Dictionary<string,string> Rules()
        {
            Dictionary<string,string> rules = new Dictionary<string,string>();
            
            rules.Add("customer_id", "string");
            rules.Add("status", "string");
            rules.Add("created_at", "datetime");

            return rules;
        }
    }
}