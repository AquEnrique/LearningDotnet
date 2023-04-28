using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionAlternativeController : ControllerBase
    {
        private QuestionAlternativeBusinessService _questionAlternativeBusinessService;
        public QuestionAlternativeController(QuestionAlternativeBusinessService questionAlternativeBusinessService)
        {
            _questionAlternativeBusinessService = questionAlternativeBusinessService;
        }

        // Get QuestionAlternatives
        [HttpGet]
        public IEnumerable<QuestionAlternative> GetQuestionAlternatives()
        {
            return _questionAlternativeBusinessService.GetQuestionAlternatives();
        }

        //Get one QuestionAlternative
        [HttpGet("{id}")]
        public QuestionAlternative? GetQuestionAlternative(long id)
        {
            return _questionAlternativeBusinessService.GetQuestionAlternative(id);
        }

        //Insert QuestionAlternative
        [HttpPost]
        public QuestionAlternative InsertQuestionAlternative(QuestionAlternative questionAlternative)
        {
            return _questionAlternativeBusinessService.InsertQuestionAlternative(questionAlternative);
        }

        //Update QuestionAlternative
        [HttpPut]
        public QuestionAlternative? UpdateQuestionAlternative(QuestionAlternative questionAlternative)
        {
            return _questionAlternativeBusinessService.UpdateQuestionAlternative(questionAlternative);
        }

        //Delete QuestionAlternative
        [HttpDelete("{id}")]
        public bool DeleteQuestionAlternative(long id)
        {
            return _questionAlternativeBusinessService.DeleteQuestionAlternative(id);
        }
    }
}