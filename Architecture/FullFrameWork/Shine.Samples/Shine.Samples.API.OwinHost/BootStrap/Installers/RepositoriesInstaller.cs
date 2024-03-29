﻿using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Shine.Samples.IRepositories;
using Shine.Samples.RepositoriesImpl.EF;

namespace Shine.Samples.API.OwinHost.BootStrap.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>().LifestylePerThread());
            container.Register(Component.For<DbContext>().ImplementedBy<SampleDataContext>().LifestylePerThread());

            container.Register(Component
                .For(typeof(IGenericRepository<>))
                .ImplementedBy(typeof(GenericRepository<>))
                .LifestylePerThread());
        }
    }
}
