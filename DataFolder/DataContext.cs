using System.Collections.Generic;
using MongoDB.Driver;
using Services.Models;
using System.Linq;

namespace Services.DataFolder
{
    public class DataContext
    {
        MongoClient _client;
        IMongoDatabase _database;
        IMongoCollection<TestRun> _testRuns;

        public DataContext()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _database = _client.GetDatabase("Automation");
            _testRuns = _database.GetCollection<TestRun>("TestRuns");
        }

        public void InsertTestRun(TestRun testRun)
        {
            _testRuns.InsertOne(testRun);
        }

        public List<TestRun> GetTestRuns()
        {
            return _testRuns.AsQueryable().ToList();
        }

        public TestRun GetTestRun(string id)
        {
            return _testRuns.Find(t => t.TestRunId == id).First();
        }
    }
}