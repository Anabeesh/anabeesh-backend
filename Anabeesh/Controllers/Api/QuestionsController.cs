using Anabeesh.DTO;
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
        public IHttpActionResult Get([FromUri] PagedListParameter dto)
        {
            return Ok(_questionsService.ListQuestions(dto.Page, dto.PageSize));
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(_questionsService.GetQuestionById(id));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] CreateQuestionDto dto)
        {
            var result = _questionsService.CreateQuestion(dto);
            return Created(Request.RequestUri + result.Id.ToString(), result);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put([FromBody] UpdateQuestionDto dto)
        {
            var result = _questionsService.UpdateQuestion(dto);
            if (result == false) return NotFound();
            return Ok();
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