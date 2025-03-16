using System;

namespace ProjectChat
{
    public abstract class Participant
    {
        protected IChatMediator _mediator;
        public string Name { get; }

        public Participant(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _mediator.RegisterParticipant(this);
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(message, this);
        }

        public abstract void ReceiveMessage(string message, Participant sender);
    }
}
