using MongoDB.Driver;
using Services.Models;

namespace Services.DataFolder
{
    public class ConfigurationsData : DataContextBase<Configuration>
    {
        public ConfigurationsData()
            :base("Configurations")
        {
        }

        public Configuration GetConfig(string siteName)
        {
            return _collection.Find(c => c.Url == siteName).First();
        }
    }
}