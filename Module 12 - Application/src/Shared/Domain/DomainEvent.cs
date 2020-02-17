using System.Collections.Generic;
using System;

namespace App.Shared.Domain
{
    public abstract class DomainEvent
    {
        private string aggregateId;
        private Dictionary<string,string> body;

        public DomainEvent(
            string aggregateId,
            Dictionary<string,string> body
        ) {
            this.aggregateId = aggregateId;
            this.SetBody(body);
        }

        private void SetBody(Dictionary<string,string> body)
        {
            this.ValidateBody(body);
            this.body = body;
        }

        private void ValidateBody(Dictionary<string,string> body)
        {
            Dictionary<string, string> rules = this.Rules();
            
            if (body.Count != rules.Count) {
                throw new System.Exception("invalid values in " + this.Name() + " event");
            }

            foreach(string key in body.Keys) {
                if (!rules.ContainsKey(key)) {

                }

                string bodyValue = body[key];
                string ruleValue = rules[key];

                if (ruleValue == "int") {
      	            int number;
                    
                    if (!int.TryParse(bodyValue, out number)) {
                        throw new System.Exception("invalid key in " + key + " " + this.Name() + " event");
                    }
                }

                if (ruleValue == "decimal") {
      	            decimal d;
                    
                    if (!decimal.TryParse(bodyValue, out d)) {
                        throw new System.Exception("invalid key in " + key + " " + this.Name() + " event");
                    }
                }

                if (ruleValue == "datetime") {
      	            DateTime date;
                    
                    if (!DateTime.TryParse(bodyValue.ToString(), out date)) {
                        throw new System.Exception("invalid key in " + key + " " + this.Name() + " event");
                    }
                }
            }
        }

        protected abstract Dictionary<string,string> Rules();

        public string AggregateId()
        {
            return this.aggregateId;
        }

        public abstract string Name();

        public Dictionary<string,string> Body()
        {
            return this.body;
        }
    }
}