using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iris.Contracts.Messages.EventHandlers
{
    public interface IMessageRecievedEventHandler
    {
        void Process(Message message, IMessageEndpoint endpoint);
    }
}
