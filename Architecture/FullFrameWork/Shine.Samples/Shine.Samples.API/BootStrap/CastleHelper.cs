using Castle.Windsor;
using Castle.Windsor.Installer;
using Shine.Samples.ApplicationServices;
using Shine.Samples.API.BootStrap.Installers;
using Shine.Samples.RepositoriesImpl.EF;

namespace Shine.Samples.API.BootStrap
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
            //Container.Install(FromAssembly.Containing<ApplicationServiceInstaller>());
            //Container.Install(FromAssembly.Containing<RepositoriesInstaller>());
            _resolver = new WindsorHttpDependencyResolver(Container);

            return _resolver;
        }
    }
}