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

            //TODO: can not use perwebrequest lifestyle, we need implement owin lifetime style
            container.Register(Component
                .For<IProjectApplicationService>()
                .ImplementedBy<ProjectApplicationService>()
               .LifestylePerThread());
        }
    }
}
