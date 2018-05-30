using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.Models
{
    [BsonIgnoreExtraElements]
    public class Configuration
    {
        public string Url { get; set; }
        public List<User> Users { get; set; }
        public string Language { get; set; }
    }
}