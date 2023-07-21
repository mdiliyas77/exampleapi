using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo.Controllers
{
    public class demoController : ApiController
    {

        [Route("AddNumbers")]
        [HttpPost]
        public int AddTwoNumbers(models obj)
        {
            service db = new service();
            int res = db.AddNumber(obj);
            return res;
        }
    }
}
