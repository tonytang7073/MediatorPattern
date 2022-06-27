using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string mesg, Colleague colleague);
    }
}
