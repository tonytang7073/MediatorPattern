using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public class Colleague1 : Colleague
    {
        public override void HandleNotification(string msg)
        {
            Console.WriteLine("Colleague 1 received message:" + msg);
        }
    }
}
