using Microsoft.EntityFrameworkCore;
using Shine.Samples.NetCore.Domains.Aggregates;
using Shine.Samples.RepositoriesImpl.EF.EntityConfigurations;

namespace Shine.Samples.NetCore.Repositories.EF
{
    public class SampleDataContext : DbContext
    {

        public DbSet<Project> Projects { get; set; }
        public SampleDataContext(DbContextOptions<SampleDataContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProjectEntityConfiguration());

        }
    }
}
