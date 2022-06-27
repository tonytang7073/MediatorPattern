namespace MediatorPattern.Structural
{
    public abstract class Colleague
    {
        protected Mediator mediator;

        internal void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string msg)
        {
            this.mediator.Send(msg, this);
        }

        public abstract void HandleNotification(string msg);
    }
}