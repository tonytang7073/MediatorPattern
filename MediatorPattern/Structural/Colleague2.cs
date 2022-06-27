using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public class Colleague2 : Colleague
    {
        public override void HandleNotification(string msg)
        {
            Console.WriteLine("Colleague 2 received message:" + msg);
        }
    }
}
