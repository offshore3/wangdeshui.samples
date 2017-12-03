using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shine.Samples.NetCore.ApplicationServices.Interfaces;
using Shine.Samples.NetCore.DTO;


namespace Shine.Samples.NetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
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


        [HttpGet("{id}")]
        // GET api/<controller>/5
        public Project Get(Guid id)
        {
            return _projectApplicationService.GetProjectById(id);
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