using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shine.Samples.DTO;

namespace Shine.Samples.ApplicationServices.Interfaces
{
    public interface IProjectApplicationService
    {
        Project GetProjectById(Guid id);
    }
}
