namespace MediatorExample.Structure
{
    public abstract class Service
    {
        protected Mediator mediator;

        //Mediator knows about all the services and each service knows about its mediator
        //public Service(Mediator mediator)
        //{
        //    this.mediator = mediator;
        //}

        internal void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            this.mediator.Send(message, this);
        }

        public abstract void ReceiveMessage(string message);
    }
}
