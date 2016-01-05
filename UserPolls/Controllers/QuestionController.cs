using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserPolls.BOs;
using UserPolls.BOs.Opearations;
using UserPolls.DAL;

namespace UserPolls.Controllers
{
    public class QuestionController : ApiController
    {
        public    IHttpActionResult Get()
        {
            ResultsDTO<PollItem[]> question = new ResultsDTO<PollItem[]>();

            question.result = PollItem.StubData();
            return Ok(question);
        }
        public IHttpActionResult Get(int id)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "result by id :" + id.ToString() };
            return Ok(str);
        }

        public IHttpActionResult Create(object PollQuestion)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "Successful update" };
            return Ok(str);
        }
        public IHttpActionResult PUT(object PollQuestion)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "Successful update" };
            return Ok(str);
        }

        public IHttpActionResult Delete(int id)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "deleted by id :" + id.ToString() };
            return Ok(str);
        }
           [ActionName("StatusUpdate")]
        public IHttpActionResult AdminUpdate(int questionId,int status)
        {
            ResultsDTO<string> str = new ResultsDTO<string>() { result = "admin approved status" + questionId.ToString() };
            return Ok(str);
        }

    }
}
