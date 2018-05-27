using MongoDB.Bson.Serialization.Attributes;

namespace Services.Models
{
    [BsonIgnoreExtraElements]
    public class Results
    {
        public int Passed { get; set; }
        public int Failed { get; set; }
        public int SentToHub { get; set; }
        public int Running { get; set; }
    }
}