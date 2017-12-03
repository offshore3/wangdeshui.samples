using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shine.Samples.NetCore.Domains;
using Shine.Samples.NetCore.Domains.Aggregates;

namespace Shine.Samples.RepositoriesImpl.EF.EntityConfigurations
{
    public class ProjectEntityConfiguration :IEntityTypeConfiguration<Project>
    {

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(50);
        }
    }
}
