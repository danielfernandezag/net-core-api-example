using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace GameCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllAsync()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            logger.Info("INFO DANIEL");
            logger.Debug("DEBUG DANIEL");
            logger.Warn("WARN DANIEL");
            logger.Error(new Exception(), "pedos");
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            logger.Info("INFO DANIEL");
            logger.Debug("DEBUG DANIEL");
            logger.Warn("WARN DANIEL");
            logger.Error(new Exception(), "pedos");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
