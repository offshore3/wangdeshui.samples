using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shine.Samples.Domains.Aggregates;

namespace Shine.Samples.RepositoriesImpl.EF.EntityConfigurations
{
    public class ProjectEntityConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectEntityConfiguration()
        {

            //http://www.entityframeworktutorial.net/code-first


            this.HasKey<Guid>(p => p.Id);

            this.Property(p => p.Name)
                .HasMaxLength(50);
        }
    }
}
