using DDDDomainEvents.Domain.Events;
using DDDDomainEvents.Domain.Handlers;
using SimpleInjector;

namespace DDDDomainEvents.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            #region Events

            container.RegisterCollection(typeof(IHandler<>), typeof(IDomainEvent).Assembly);

            #endregion
        }

        public static void Raise<TEventEntity>(Container container, TEventEntity eventEntity) where TEventEntity : IDomainEvent
        {
            var handles = container.GetAllInstances<IHandler<TEventEntity>>();
            foreach (var handle in handles)
            {
                handle.Handler(eventEntity);
            }
        }
    }
}