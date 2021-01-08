using elearning.Shared.Domain.Bus.Event;
using System.Collections.Generic;

namespace elearning.Shared.Domain
{
    public abstract class AggregateRoot
    {
        private List<DomainEvent> events;

        public AggregateRoot()
        {
            events = new List<DomainEvent>();
        }

        protected void Record(DomainEvent domainEvent)
        {
            events.Add(domainEvent);
        }

        public List<DomainEvent> ReleaseEvents()
        {
            List<DomainEvent> events = this.events;
            RemoveEvents();

            return events;
        }

        private void RemoveEvents()
        {
            events = new List<DomainEvent>();
        }
    }
}
