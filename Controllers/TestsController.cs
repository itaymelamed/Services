using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Services.DataFolder;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    public class TestsController : Controller
    {
        // GET: api/tests/3
        [HttpGet("{testRunId}")]
        public IEnumerable<Test> Get(string testRunId)
        {
            TestsData testsData = new TestsData();
            return testsData.GetDocuments().Where(t => t.TestRunId == testRunId);
        }

        // GET: api/tests/3/status/Failed
        [HttpGet("{testRunId}/status/{status}")]
        public IEnumerable<Test> Get(string testRunId, string status)
        {
            TestsData testsData = new TestsData();
            return testsData.GetDocuments().Where(t => t.TestRunId == testRunId && t.Result.Status == status);
        }

        // GET api/tests/testnumber/5
        [HttpGet("testnumber/{testNumber}")]
        public Test Get(int testNumber)
        {
            TestsData testsData = new TestsData();
            return testsData.GetTest(testNumber);
        }

        // POST api/tests
        [HttpPost]
        public void Post([FromBody]Test test)
        {
            TestsData testsData = new TestsData();
            testsData.UpsertTest(test);
        }
    }
}