using System;
using DDDDomainEvents.Domain.Events;

namespace DDDDomainEvents.Domain.Handlers
{
    public class PersonSave : IHandler<PersonRegisteredEvent>
    {
        public void Handler(PersonRegisteredEvent args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Registro Salvo {args.PersonId}:{args.Name}");
        }
    }
}