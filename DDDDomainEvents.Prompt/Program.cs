using System;
using DDDDomainEvents.Domain.Entities;
using DDDDomainEvents.Domain.Events;
using DDDDomainEvents.IoC;
using SimpleInjector;

namespace DDDDomainEvents.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            BootStrapper.RegisterServices(container);

            var person = new Person
            {
                PersonId = new Guid(),
                Name = "Tiago Pariz"
            };

            var save = new PersonRegisteredEvent(person.PersonId, person.Name);

            BootStrapper.Raise(container, save);

            Console.ReadKey();
        }
    }
}