using Castle.Windsor;
using Castle.Windsor.Installer;
using Shine.Samples.API.OwinHost.BootStrap.Installers;

namespace Shine.Samples.API.OwinHost.BootStrap
{
    public static class CastleHelper
    {
        public static WindsorContainer Container { get; private set; }
        private static WindsorHttpDependencyResolver _resolver;
        private static bool _initialized;

        static CastleHelper()
        {
            Container = new WindsorContainer();
            _initialized = false;
        }

        public static WindsorHttpDependencyResolver GetDependencyResolver()
        {
            if (_initialized)
                return _resolver;

            _initialized = true;
            Container.Install(FromAssembly.This());
            _resolver = new WindsorHttpDependencyResolver(Container);

            return _resolver;
        }
    }
}