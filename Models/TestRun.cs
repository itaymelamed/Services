using MongoDB.Bson.Serialization.Attributes;

namespace Services.Models
{
    [BsonIgnoreExtraElements]
    public class TestRun
    {
        public string TestRunId { get; set; }
        public string Env { get; set; }
        public string Date { get; set; }
        public Results Results { get; set; }
        public string Duration { get; set; }
        public string SiteName { get; set; }
        public string Category { get; set; }
        public string User { get; set; }
    }
}