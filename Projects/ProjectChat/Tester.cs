using System;

namespace ProjectChat
{
    public class Tester : Participant
    {
        public Tester(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message, Participant sender)
        {
            Form1.Instance.UpdateChat($"[Тестировщик] {sender.Name}: {message}");
        }
    }
}
