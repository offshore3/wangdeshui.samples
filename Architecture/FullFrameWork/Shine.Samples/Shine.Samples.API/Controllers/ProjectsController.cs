using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shine.Samples.ApplicationServices.Interfaces;
using Shine.Samples.DTO;

namespace Shine.Samples.API.Controllers
{
    public class ProjectsController : ApiController
    {
        private readonly IProjectApplicationService _projectApplicationService;

        public ProjectsController(IProjectApplicationService projectApplicationService)
        {
            _projectApplicationService = projectApplicationService;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Project Get(int id)
        {
            return _projectApplicationService.GetProjectById(Guid.NewGuid());
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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