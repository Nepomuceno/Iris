using Owin;
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
            app.MapHubs("/server",new Microsoft.AspNet.SignalR.HubConfiguration(){EnableCrossDomain = true});
        }
    }
}
