using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Shine.Samples.IRepositories;

namespace Shine.Samples.RepositoriesImpl.EF
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>().LifestylePerWebRequest());
            container.Register(Component.For<DbContext>().ImplementedBy<SampleDataContext>().LifestylePerWebRequest());

            container.Register(Component
                .For(typeof(IGenericRepository<>))
                .ImplementedBy(typeof(GenericRepository<>))
                .LifestylePerWebRequest());
        }
    }
}
