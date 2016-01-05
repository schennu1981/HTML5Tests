using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserPolls.BOs;

namespace UserPolls.Controllers
{
    public class ResultController : ApiController
    {
        public IHttpActionResult Create(object userVote)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "Successful update" };
            return Ok(str);
        }

        public IHttpActionResult Put(object userPollResul)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { status = ResultsDTO<string>.error, result = "You can not update the result again." };
            return Ok(str);
        }
        public IHttpActionResult Get()
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "All results" };
            return Ok(str);
        }
        public IHttpActionResult Get(int id)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "result by id :" + id.ToString() };
            return Ok(str);
        } 

    }
}
