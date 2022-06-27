using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public class ConcreteMediator : Mediator
    {
        private List<Colleague> collegs = new List<Colleague>();
        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.collegs.Add(colleague);
        }

        public T CreateColleague<T>() where T : Colleague, new()
        {
            var c = new T();
            c.SetMediator(this);
            this.collegs.Add(c);
            return c;
        }

        public override void Send(string mesg, Colleague colleague)
        {
            this.collegs.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(mesg)); //send to eveyone except itself.
        }
    }
}
