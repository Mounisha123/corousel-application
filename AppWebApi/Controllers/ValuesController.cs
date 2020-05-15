
using System.Collections.Generic;
using System.Web.Http;
using Application.Models.Models;
using Application.BL.Interfaces;
using System.Web.Http.Cors;

namespace AppWebApi.Controllers
{
    
    public class ValuesController : ApiController
    {
        private readonly IBL _BL;
        public ValuesController(IBL BL)
        {
            _BL = BL;
        }

        // GET api/values/5
        //[Route("api/ValuesController/GetUser")]
        //[HttpGet]
        public IEnumerable<AppModel> Get()
        {
            return _BL.GetAppData();
        }

        // POST api/values
        //[Route("api/ValuesController/PostUser")]
        //[HttpPost]
        public IEnumerable<AppModel> Post(AppModel value)
        {
            return _BL.InsertAppData(value);

        }

        // PUT api/values/5
        //[Route("api/ValuesController/PutUser")]
        //[HttpPut]
        public string Put(int appId, AppModel value)
        {
            return _BL.UpdateAppData(appId, value);
        }


        // DELETE api/values/5
        //[Route("api/ValuesController/DeleteUser")]
        //[HttpDelete]
       
    }
}
