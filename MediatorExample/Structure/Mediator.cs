namespace MediatorExample.Structure
{
    public abstract class Mediator
    {
        public abstract void Register(Service service);
        public abstract void Send(string message, Service service);
    }
}
