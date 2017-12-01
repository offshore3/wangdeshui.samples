using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Shine.Samples.ApplicationServices.Impl;
using Shine.Samples.ApplicationServices.Interfaces;

namespace Shine.Samples.ApplicationServices
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
