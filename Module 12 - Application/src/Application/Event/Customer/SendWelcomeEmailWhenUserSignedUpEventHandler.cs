using System;
using System.Reflection;
using App.Domain.CustomerAggregate;
using App.Shared.Domain;
using App.Shared.Domain.Bus.Event;

namespace App.Application.Event
{
    public class SendWelcomeEmailWhenUserSignedUpEventHandler : IEventHandler
    {
        public void Handle(DomainEvent domainEvent)
        {
        }
    }
}