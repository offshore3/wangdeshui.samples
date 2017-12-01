using System;

namespace Shine.Samples.Domains.Aggregates
{
   public class Project: AggregateRoot
    {
        public string Name { get; set; }
    }
}
