using ChirperWebApiAngular.Adapters.Adapters;
using ChirperWebApiAngular.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChirperWebApiAngular.Controllers
{
    public class apiUserController : ApiController
    {
        private IUser _adapter2;
        public apiUserController() 
        {
            _adapter2 = new UserAdapter();
        }
        [HttpGet]
        public IHttpActionResult GetUser(int id = -1)
        {
            if (id == -1)
            {
                return Ok(_adapter2.GetListUsers());
            }
            else
            {
                return Ok(_adapter2.GetUser(id));
            }
        }
    }
}
