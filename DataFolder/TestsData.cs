using MongoDB.Driver;
using Services.Models;

namespace Services.DataFolder
{
    public class TestsData : DataContextBase<Test>
    {
        public TestsData()
            :base("Tests")
        {
        }

        public Test GetTest(int testNumber)
        {
            return _collection.Find(t => t.TestNumber == testNumber).First();
        }

        public void UpsertTest(Test test)
        {
            UpdateOptions options = new UpdateOptions();
            options.IsUpsert = true;
            var filter = Builders<Test>.Filter.Where(t => t.TestNumber == test.TestNumber);
            _collection.ReplaceOne(filter, test, options);
        }
    }
}