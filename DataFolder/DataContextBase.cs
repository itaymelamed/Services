using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace Services.DataFolder
{
    public class DataContextBase<T>
    {
        MongoClient _client;
        IMongoDatabase _database;
        protected IMongoCollection<T> _collection;

        public DataContextBase(string collection)
        {
            _client = new MongoClient("mongodb://mongo:27017");
            _database = _client.GetDatabase("Automation");
            _collection = _database.GetCollection<T>(collection);
        }

        public void InsertDocument(T document)
        {
            _collection.InsertOne(document);
        }

        public List<T> GetDocuments()
        {
            return _collection.AsQueryable().ToList();
        }
    }
}