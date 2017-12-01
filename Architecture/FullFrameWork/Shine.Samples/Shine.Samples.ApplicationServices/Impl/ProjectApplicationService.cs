using System;
using Shine.Samples.ApplicationServices.Interfaces;
using Shine.Samples.DTO;

namespace Shine.Samples.ApplicationServices.Impl
{
    public class ProjectApplicationService : IProjectApplicationService
    {
        public Project GetProjectById(Guid id)
        {
            return new Project {Id = Guid.NewGuid(), Name = "Test"};
        }
    }
}