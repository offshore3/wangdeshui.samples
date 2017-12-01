using System;
using Shine.Samples.ApplicationServices.Interfaces;
using Shine.Samples.DTO;
using Shine.Samples.IRepositories;
using Shine.Samples.Domains;

namespace Shine.Samples.ApplicationServices.Impl
{
    public class ProjectApplicationService : IProjectApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Domains.Aggregates.Project> _projectRepository;

        public ProjectApplicationService(IUnitOfWork unitOfWork, IGenericRepository<Domains.Aggregates.Project> projectRepository)
        {
            _unitOfWork = unitOfWork;
            _projectRepository = projectRepository;
        }

        public void AddProject(Project project)
        {
            Domains.Aggregates.Project domainProject =
                new Domains.Aggregates.Project { Id = Guid.NewGuid(), Name =project.Name };

            _projectRepository.Add(domainProject);

            _unitOfWork.Commit();
        }

        public Project GetProjectById(Guid id)
        {

            var project = _projectRepository.Get(id);

            return new Project {Id = project.Id, Name = project.Name};

            
        }
    }
}