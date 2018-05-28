using MongoDB.Driver;
using Services.Models;

namespace Services.DataFolder
{
    public class TestRunsData : DataContextBase<TestRun>
    {
        public TestRunsData()
            :base("TestRuns")
        {
        }

        public TestRun GetTestRun(int id)
        {
            return _collection.Find(t => t.TestRunId == id).First();
        }
    }
}