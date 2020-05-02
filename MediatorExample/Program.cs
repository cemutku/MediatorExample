using MediatorExample.Structure;
using System;

namespace MediatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var service1 = mediator.CreateService<Service1>();
            var service2 = mediator.CreateService<Service2>();

            service1.Send("Hello from Service1");
            service2.Send("Hello from Service2");

            Console.ReadLine();

            // Encapsulate object interaction with loose coupling
            // Service objects do not have to know each other
        }
    }
}
