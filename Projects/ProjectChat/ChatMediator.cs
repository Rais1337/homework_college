using System;
using System.Collections.Generic;

namespace ProjectChat
{
    public class ChatMediator : IChatMediator
    {
        private List<Participant> participants = new List<Participant>();

        public void RegisterParticipant(Participant participant)
        {
            participants.Add(participant);
        }

        public void SendMessage(string message, Participant sender)
        {
            foreach (var participant in participants)
            {
                if (participant != sender)
                {
                    participant.ReceiveMessage(message, sender);
                }
            }
        }
    }
}
