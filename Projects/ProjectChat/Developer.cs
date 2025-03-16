using System;

namespace ProjectChat
{
    public class Developer : Participant
    {
        public Developer(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message, Participant sender)
        {
            Form1.Instance.UpdateChat($"[Программист] {sender.Name}: {message}");
        }
    }
}
