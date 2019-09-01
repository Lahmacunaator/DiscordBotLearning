using System.Linq;
using Test.Discord;
using Test.Storage;
using Test.Storage.Implementations;
using Unity;
using Unity.Lifetime;
using Unity.Resolution;

namespace Test
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
            _container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
            _container.RegisterType<Connection>(new ContainerControlledLifetimeManager());
            //_container.RegisterSingleton<Logger>();
        }

        internal static T Resolve<T>()
        {
            return _container.Resolve<T>();
            //return (T)Container.Resolve<T>(string.Empty, new ResolverOverride[2]);
        }
    }
}
