using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.CartAggregate.Event
{
    public class CartClosedEvent : DomainEvent
    {
        public CartClosedEvent(string aggregateId, Dictionary<string,string> body) : base(aggregateId, body){}
        
        public override string Name()
        {
            return "cart_closed";
        }

        protected override Dictionary<string,string> Rules()
        {
            Dictionary<string,string> rules = new Dictionary<string,string>();
            
            rules.Add("status", "string");

            return rules;
        }
    }
}