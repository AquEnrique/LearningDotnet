using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private QuestionBusinessService _questionBusinessService;
        public QuestionController(QuestionBusinessService questionBusinessService)
        {
            _questionBusinessService = questionBusinessService;
        }

        // Get Questions
        [HttpGet]
        public IEnumerable<Question> GetQuestions()
        {
            return _questionBusinessService.GetQuestions();
        }

        //Get one Question
        [HttpGet("{id}")]
        public Question? GetQuestion(long id)
        {
            return _questionBusinessService.GetQuestion(id);
        }

        //Insert Question
        [HttpPost]
        public Question InsertQuestion(Question question)
        {
            return _questionBusinessService.InsertQuestion(question);
        }

        //Update Question
        [HttpPut]
        public Question? UpdateQuestion(Question question)
        {
            return _questionBusinessService.UpdateQuestion(question);
        }

        //Delete Question
        [HttpDelete("{id}")]
        public bool DeleteQuestion(long id)
        {
            return _questionBusinessService.DeleteQuestion(id);
        }
    }
}