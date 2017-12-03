using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Shine.Samples.NetCore.ApplicationServices.Interfaces;
using Shine.Samples.NetCore.API.Hubs;
using Shine.Samples.NetCore.DTO;


namespace Shine.Samples.NetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private readonly IProjectApplicationService _projectApplicationService;
        private readonly IHubContext<HelloHub> _helloHub;

        public ProjectsController(IProjectApplicationService projectApplicationService, IHubContext<HelloHub> helloHub)
        {
            _projectApplicationService = projectApplicationService;
            _helloHub = helloHub;
        }


        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpGet("{id}")]
        // GET api/<controller>/5
        public async Task<Project> Get(Guid id)
        {
            await _helloHub.Clients.All.InvokeAsync("Hello", DateTime.UtcNow+"from server");
            return _projectApplicationService.GetProjectById(id);
        }

        [HttpPost]

        // POST api/<controller>
        public void Post([FromBody]Project project)
        {
            project.Id = Guid.NewGuid();
            _projectApplicationService.Add(project);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}