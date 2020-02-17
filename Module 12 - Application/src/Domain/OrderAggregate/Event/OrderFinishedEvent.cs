using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.OrderAggregate.Event
{
    public class OrderFinishedEvent : DomainEvent
    {
        public OrderFinishedEvent(string aggregateId, Dictionary<string,string> body) : base(aggregateId, body){}
        
        public override string Name()
        {
            return "order_finished";
        }

        protected override Dictionary<string,string> Rules()
        {
            Dictionary<string,string> rules = new Dictionary<string,string>();
            
            rules.Add("status", "string");

            return rules;
        }
    }
}