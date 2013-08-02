using Iris.Contracts.Messages;
using Iris.Server.Messages;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris.Server
{
    public static class IocRegister
    {
        public static void InstallIrisDependency(this Container container)
        {
            container.Register<IKeyGenerator, KeyGenerator>(Lifestyle.Singleton);
        }
    }
}
