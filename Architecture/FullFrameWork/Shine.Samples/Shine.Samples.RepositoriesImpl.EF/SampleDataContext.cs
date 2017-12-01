using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shine.Samples.Domains.Aggregates;
using Shine.Samples.RepositoriesImpl.EF.EntityConfigurations;

namespace Shine.Samples.RepositoriesImpl.EF
{
    public class SampleDataContext : DbContext
    {

        public DbSet<Project> Projects { get; set; }
        public SampleDataContext():base("SampleDBConnectionString")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProjectEntityConfiguration());
        }
    }
}
