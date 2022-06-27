using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.ChatApp
{
    public class TeamChatroom : Chatroom
    {
        private List<TeamMember> _members = new List<TeamMember>();
        public override void Register(TeamMember member)
        {
            member.SetChatroom(this);
            this._members.Add(member);
        }

        public override void Send(string from, string message)
        {
            this._members.ForEach(m => m.Receive(from, message));
        }

        public override void SendTo<T>(string from, string message)
        {
            this._members.OfType<T>().ToList().ForEach(m => m.Receive(from, message));
        }


        public void RegisterMembers(params TeamMember[] teamMembers)
        {
            foreach (var member in teamMembers)
            {
                this.Register(member);
            }
        }
    }
}
