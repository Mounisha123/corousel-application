using Application.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppWebApi.Controllers
{
    public class SoftDeleteController : ApiController
    {
        // GET: api/SoftDelete
        private readonly IBL _BL;
        public SoftDeleteController(IBL BL)
        {
            _BL = BL;
        }
        

        // GET: api/SoftDelete/5
        public string Get(int id)
        {
            return _BL.DeleteAppData(id);
        }

        // POST: api/SoftDelete
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SoftDelete/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SoftDelete/5
        public void Delete(int id)
        {
        }
    }
}
