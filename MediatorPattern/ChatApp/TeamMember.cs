namespace MediatorPattern.ChatApp
{
    public abstract class TeamMember
    {
        private Chatroom _chatroom;
        public string Name { get; set; }    

        internal void SetChatroom(Chatroom chatroom)
        {
            this._chatroom = chatroom;
        }

        public void Send(string msg)
        {
            this._chatroom.Send(this.Name, msg);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"from {from}: '{message}'");
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            this._chatroom.SendTo<T>(this.Name, message);
        }

    }
}