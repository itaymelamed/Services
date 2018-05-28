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

        public Test GetTest(int id)
        {
            return _collection.Find(t => t.TestNumber == id).First();
        }
    }
}