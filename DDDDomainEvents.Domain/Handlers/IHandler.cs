using DDDDomainEvents.Domain.Events;

namespace DDDDomainEvents.Domain.Handlers
{
    public interface IHandler<in TEventEntity> where TEventEntity : IDomainEvent
    {
        void Handler(TEventEntity args);
    }
}