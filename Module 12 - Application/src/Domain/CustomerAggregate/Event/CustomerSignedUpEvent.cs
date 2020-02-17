using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.CustomerAggregate.Event
{
    public class CustomerSignedUpEvent : DomainEvent
    {
        public CustomerSignedUpEvent(string aggregateId, Dictionary<string,string> body) : base(aggregateId, body){}

        public override string Name()
        {
            return "customer_signed_up";
        }

        protected override Dictionary<string,string> Rules()
        {
            Dictionary<string,string> rules = new Dictionary<string,string>();
            
            rules.Add("email", "string");
            rules.Add("first_name", "string");
            rules.Add("last_name", "string");
            rules.Add("country", "string");
            rules.Add("created_at", "datetime");

            return rules;
        }
    }
}
