using Anabeesh.DTO.Questions;
using Anabeesh.Services.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Anabeesh.Controllers.Api
{
    public class QuestionsController : ApiController
    {
        private QuestionsService _questionsService;

        public QuestionsController()
        {
            _questionsService = new QuestionsService();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] CreateQuestionDto dto)
        {
            var result = _questionsService.CreateQuestion(dto);
            return Created(Request.RequestUri + result.Id.ToString(), result);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(long id)
        {
            var result = _questionsService.DeleteQuestion(id);
            if (result == false) return NotFound();
            return Ok();
        }
    }
}