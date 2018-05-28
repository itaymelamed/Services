using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services.DataFolder;
using Services.Models;
using System.Linq;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    public class TestRunsController : Controller
    {
        // GET: api/TestRuns
        [HttpGet]
        public IEnumerable<TestRun> Get()
        {
            TestRunsData dataContext = new TestRunsData();
            return dataContext.GetDocuments();
        }

        // GET: api/TestRuns/Editor
        [HttpGet("{category}")]
        public IEnumerable<TestRun> Get(string category)
        {
            TestRunsData dataContext = new TestRunsData();
            return dataContext.GetDocuments().Where(t => t.Category == category);
        }

        // GET api/TestRuns/5
        [HttpGet("{id}")]
        public TestRun Get(int id)
        {
            TestRunsData dataContext = new TestRunsData();
            return dataContext.GetTestRun(id);
        }

        // POST api/TestRuns
        [HttpPost]
        public void Post([FromBody]TestRun testRun)
        {
            TestRunsData dataContext = new TestRunsData();
            dataContext.InsertDocument(testRun);
        }
    }
}