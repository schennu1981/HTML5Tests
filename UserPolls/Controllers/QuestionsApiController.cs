using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserPolls.Controllers
{
    public class QuestionsApiController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // GET: api/QuestionsApi/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/QuestionsApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/QuestionsApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/QuestionsApi/5
        public void Delete(int id)
        {
        }
    }
}
