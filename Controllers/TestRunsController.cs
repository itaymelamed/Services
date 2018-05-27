using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services.DataFolder;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    public class TestRunsController : Controller
    {
        // GET: api/TestRuns
        [HttpGet]
        public IEnumerable<TestRun> Get()
        {
            DataContext dataContext = new DataContext();
            return dataContext.GetTestRuns();
        }

        // GET api/TestRuns/5
        [HttpGet("{id}")]
        public TestRun Get(string id)
        {
            DataContext dataContext = new DataContext();
            return dataContext.GetTestRun(id);
        }

        // POST api/TestRuns
        [HttpPost]
        public void Post([FromBody]TestRun testRun)
        {
            DataContext dataContext = new DataContext();
            dataContext.InsertTestRun(testRun);
        }
    }
}