using App.Shared.Domain;
using System.Collections.Generic;

namespace App.Domain.ProductAggregate.Event
{
    public class ProductCreatedEvent : DomainEvent
    {
        public ProductCreatedEvent(string aggregateId, Dictionary<string,string> body) : base(aggregateId, body){}
        
        public override string Name()
        {
            return "product_created";
        }

        protected override Dictionary<string,string> Rules()
        {
            Dictionary<string,string> rules = new Dictionary<string,string>();
            
            rules.Add("name", "string");
            rules.Add("description", "string");
            rules.Add("price", "decimal");

            return rules;
        }
    }
}