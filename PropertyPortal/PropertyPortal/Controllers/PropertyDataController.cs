using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PropertyPortal.Controllers
{
    public class PropertyDataController : ApiController
    {
        // GET: api/PropertyData
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PropertyData/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PropertyData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PropertyData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PropertyData/5
        public void Delete(int id)
        {
        }
    }
}
