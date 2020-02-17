using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.PaymentAggregate.Event
{
    public class PaymentCreatedEvent : DomainEvent
    {
        public PaymentCreatedEvent(string aggregateId, Dictionary<string,string> body) : base(aggregateId, body){}
        
        public override string Name()
        {
            return "payment_created";
        }

        protected override Dictionary<string,string> Rules()
        {
            Dictionary<string,string> rules = new Dictionary<string,string>();
            
            rules.Add("price", "decimal");
            rules.Add("method", "string");
            rules.Add("order_id", "string");
            rules.Add("customer_id", "string");
            rules.Add("created_at", "datetime");

            return rules;
        }
    }
}