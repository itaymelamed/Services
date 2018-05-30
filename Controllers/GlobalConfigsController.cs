using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services.DataFolder;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    public class GlobalConfigsController : Controller
    {
        // GET: api/globalconfigs
        [HttpGet]
        public IEnumerable<GlobalConfig> Get()
        {
            DataContextBase<GlobalConfig> dataContext = new DataContextBase<GlobalConfig>("GlobalConfigs");
            return dataContext.GetDocuments();
        }

        // GET api/globalconfigs/5
        [HttpGet("{i}")]
        public GlobalConfig Get(int i)
        {
            DataContextBase<GlobalConfig> dataContext = new DataContextBase<GlobalConfig>("GlobalConfigs");
            return dataContext.GetDocumentByIndex(i);
        }
    }
}
