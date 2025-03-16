using System;

namespace ProjectChat
{
    public interface IChatMediator
    {
        void SendMessage(string message, Participant sender);
        void RegisterParticipant(Participant participant);
    }
}
