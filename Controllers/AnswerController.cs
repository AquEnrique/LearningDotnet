using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController : ControllerBase
    {
        private AnswerBusinessService _answerBusinessService;
        public AnswerController(AnswerBusinessService answerBusinessService)
        {
            _answerBusinessService = answerBusinessService;
        }

        // Get Answers
        [HttpGet]
        public IEnumerable<Answer> GetAnswers()
        {
            return _answerBusinessService.GetAnswers();
        }

        //Get one Answer
        [HttpGet("{id}")]
        public Answer? GetAnswer(long id)
        {
            return _answerBusinessService.GetAnswer(id);
        }

        //Insert Answer
        [HttpPost]
        public Answer InsertAnswer(Answer answer)
        {
            return _answerBusinessService.InsertAnswer(answer);
        }

        //Update Answer
        [HttpPut]
        public Answer? UpdateAnswer(Answer answer)
        {
            return _answerBusinessService.UpdateAnswer(answer);
        }

        //Delete Answer
        [HttpDelete("{id}")]
        public bool DeleteAnswer(long id)
        {
            return _answerBusinessService.DeleteAnswer(id);
        }
    }
}