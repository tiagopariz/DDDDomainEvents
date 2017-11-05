using System;

namespace DDDDomainEvents.Domain.Events
{
    public class PersonRegisteredEvent : IDomainEvent
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }

        public PersonRegisteredEvent(Guid personId, string name)
        {
            PersonId = personId;
            Name = name;
        }
    }
}