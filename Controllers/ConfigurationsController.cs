using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services.DataFolder;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    public class ConfigurationsController : Controller
    {
        // GET api/configurations/90Min
        [HttpGet("{siteName}")]
        public Configuration Get(string siteName)
        {
            ConfigurationsData configurationsData = new ConfigurationsData();
            return configurationsData.GetConfig(siteName);
        }

        // GET api/configurations/
        [HttpGet]
        public IEnumerable<Configuration> GetList()
        {
            ConfigurationsData configurationsData = new ConfigurationsData();
            return configurationsData.GetDocuments();
        }
    }
}