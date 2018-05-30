using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.Models
{
    [BsonIgnoreExtraElements]
    public class GlobalConfig
    {
        public List<User> Users { get; set; }
        public string Echo { get; set; }
        public string Influencers { get; set; }
        public string Monti { get; set; }
        public List<Proxy> Proxies { get; set; }
        public ApiConfig ApiConfig { get; set; }
        public FaceBookApi FaceBookApi { get; set; }
    }
}