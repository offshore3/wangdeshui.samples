using System;

namespace Shine.Samples.NetCore.Domains.Aggregates
{
   public class Project: AggregateRoot
    {
        public string Name { get; set; }
    }
}
