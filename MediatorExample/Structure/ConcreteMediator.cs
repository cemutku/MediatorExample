using System.Collections.Generic;
using System.Linq;

namespace MediatorExample.Structure
{
    public class ConcreteMediator : Mediator
    {
        private List<Service> services = new List<Service>();

        public override void Send(string message, Service service)
        {
            // Send message to all services excecpt received one

            this.services
                .Where(s => s != service)
                .ToList()
                .ForEach(m => m.ReceiveMessage(message));
        }

        public override void Register(Service service)
        {
            service.SetMediator(this);
            this.services.Add(service);
        }

        public T CreateService<T>() where T : Service, new()
        {
            var c = new T();
            c.SetMediator(this);
            this.services.Add(c);
            return c;
        }
    }
}
