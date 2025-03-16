using System;

namespace ProjectChat
{
    public class Customer : Participant
    {
        public Customer(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message, Participant sender)
        {
            Form1.Instance.UpdateChat($"[Заказчик] {sender.Name}: {message}");
        }
    }
}
