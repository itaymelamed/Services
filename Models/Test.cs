using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.Models
{
    [BsonIgnoreExtraElements]
    public class Test
    {
        public int TestNumber { get; set; }
        public string TestName { get; set; }
        public List<string> Steps { get; set; }
        public Result Result { get; set; }
        public string TestRunId { get; set; }
        public string Date { get; set; }
        public string EnvironmentType { get; }
        public string SessionId { get; set; }
    }
}