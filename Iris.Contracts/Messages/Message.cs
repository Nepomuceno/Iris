using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iris.Contracts.Messages
{
    public class Message
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public byte[] Content { get; set; }
        public string Type { get; set; }
        public Encoding Encoding { get; set; }
    }
}
