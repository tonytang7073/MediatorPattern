using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.ChatApp
{
    public class Tester : TeamMember
    {
        public override void Receive(string from, string message)
        {
            Console.Write($"{this.Name} ({nameof(Tester)}) has received: ");
            base.Receive(from, message);
        }
    }
}
