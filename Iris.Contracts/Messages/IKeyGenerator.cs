using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iris.Contracts.Messages
{
    public interface IKeyGenerator
    {
        string GenerateKey(Message message);
    }
}
