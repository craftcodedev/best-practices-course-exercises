﻿using System.Collections.Generic;
using CraftCodeApp.src.Shared.Domain.Event;

namespace CraftCodeApp.src.Shared.Domain
{
    public abstract class AggregateRoot
    {
        private List<DomainEvent> events;

        public AggregateRoot()
        {
            this.events = new List<DomainEvent>();
        }

        protected void Record(DomainEvent domainEvent)
        {
            this.events.Add(domainEvent);
        }

        public List<DomainEvent> ReleaseEvents()
        {
            List<DomainEvent> events = this.events;
            this.RemoveEvents();

            return events;
        }

        private void RemoveEvents()
        {
            this.events = new List<DomainEvent>();
        }
    }
}
