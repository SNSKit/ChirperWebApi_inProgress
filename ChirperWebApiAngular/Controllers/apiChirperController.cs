using Chirper.Data.Models;
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
    public class apiChirperController : ApiController
    {
        private IChirp _adapter;

        
        public apiChirperController()
        {
            _adapter = new ChirpAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            ////if (id == -1)
            ////{
            ////    return Ok(_adapter.GetAllChirps());
            ////}
            //else
            //{
            return Ok(_adapter.GetChirp());
            //}
        }
        [HttpPost]
        public IHttpActionResult Post(UserChirpVM newChirp)
        { 
            _adapter.AddChirp(newChirp);
            return Ok();
        }
    }
}

