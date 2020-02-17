using App.Shared.Domain;
using App.Shared.Domain.Bus.Event;
using System.Collections.Generic;
using System;

namespace App.Shared.Infrastructure.Bus.Event
{
    public class EventBusSync : IEventBus
    {
        private Dictionary<string, Dictionary<string, IEventHandler>> eventHandlers;

        public EventBusSync()
        {
            this.eventHandlers = new Dictionary<string, Dictionary<string, IEventHandler>>();
        }
		
        public void Subscribe(IEventHandler eventHandler, string eventName)
        {
            string className = eventHandler.GetType().ToString();
            Dictionary<string, IEventHandler> eventHandlers = new Dictionary<string, IEventHandler>();

            if (this.eventHandlers.ContainsKey(eventName)) {
                eventHandlers = this.eventHandlers[eventName];
            }

            eventHandlers.Add(className, eventHandler);
            
            this.eventHandlers.Add(eventName, eventHandlers);
        }

        public void Dispatch(DomainEvent domainEvent)
        {
            string eventName = domainEvent.GetType().ToString();

            if (!this.eventHandlers.ContainsKey(eventName)) {
                return;
            }
            
            Dictionary<string, IEventHandler> eventHandlers = this.eventHandlers[eventName];

            foreach (string key in eventHandlers.Keys) {
                eventHandlers[key].Handle(domainEvent);
            }
        }
    }
}