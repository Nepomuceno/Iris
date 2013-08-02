using Iris.Contracts.Messages;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris.Server
{
    public class MessageEndpoint : Hub
    {
        private IKeyGenerator _keyGenerator;
        public MessageEndpoint(IKeyGenerator keyGenerator)
        {
            _keyGenerator = keyGenerator;
        }
        public async Task<string> Send(Message message)
        {
            var key = _keyGenerator.GenerateKey(message);
            return await Task.Run<string>(() => { return key; });
        }
    }
}
