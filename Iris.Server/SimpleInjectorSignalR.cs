using Microsoft.AspNet.SignalR;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris.Server
{
    public class SimpleInjectorSignalR : Microsoft.AspNet.SignalR.IDependencyResolver
    {
        private Container _container;
        private DefaultDependencyResolver _defaultResolver;
        public SimpleInjectorSignalR(Container container)
        {
            _container = container;
            _defaultResolver = new DefaultDependencyResolver();
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return _container.GetInstance(serviceType);
            }
            catch (ActivationException)
            {
                return _defaultResolver.Resolve(serviceType);
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.GetAllInstances(serviceType);
            }
            catch (ActivationException)
            {
                return _defaultResolver.ResolveAll(serviceType);
            }
        }

        public void Register(Type serviceType, IEnumerable<Func<object>> activators)
        {
            _container.RegisterAll(serviceType,activators);
        }

        public void Register(Type serviceType, Func<object> activator)
        {
            _container.Register(serviceType, activator);
        }

        public void Dispose()
        {
            _container = null;
        }
    }
}
