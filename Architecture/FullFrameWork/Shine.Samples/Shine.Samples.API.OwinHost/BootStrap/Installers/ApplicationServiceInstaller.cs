using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Shine.Samples.ApplicationServices.Impl;
using Shine.Samples.ApplicationServices.Interfaces;

namespace Shine.Samples.API.OwinHost.BootStrap.Installers
{
    public class ApplicationServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IProjectApplicationService>()
                .ImplementedBy<ProjectApplicationService>()
               .LifestylePerWebRequest());
        }
    }
}
