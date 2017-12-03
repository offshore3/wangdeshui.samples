using System;
using Shine.Samples.NetCore.DTO;

namespace Shine.Samples.NetCore.ApplicationServices.Interfaces
{
    public interface IProjectApplicationService
    {
        Project GetProjectById(Guid id);
    }
}
