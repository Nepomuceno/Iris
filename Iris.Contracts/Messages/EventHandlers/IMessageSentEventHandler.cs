using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iris.Contracts.Messages.EventHandler
{
    public interface IMessageSentEventHandler
    {
        void Process(Message message, ITransmitter transmitter);
    }
}
