using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris.Contracts.Messages
{
    /// <summary>
    /// Responsable for receiving messages and trigger events related to the receiving process
    /// </summary>
    public interface IMessageEndpoint
    {
        Task<string> Send(Message message);
    }
}
