using Owin;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ContainerOptions containerOptions = new ContainerOptions();
            Container container = new Container(containerOptions);
            container.InstallIrisDependency();
            var hubConfig = new Microsoft.AspNet.SignalR.HubConfiguration()
            {
                EnableCrossDomain = true,
                Resolver = new SimpleInjectorSignalR(container)
            };
            app.MapHubs("/server",hubConfig);
        }
    }
}
