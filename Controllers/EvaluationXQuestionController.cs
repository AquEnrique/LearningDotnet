using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvaluationXQuestionController : ControllerBase
    {
        private EvaluationXQuestionBusinessService _evaluationXQuestionBusinessService;
        public EvaluationXQuestionController(EvaluationXQuestionBusinessService evaluationXQuestionBusinessService)
        {
            _evaluationXQuestionBusinessService = evaluationXQuestionBusinessService;
        }

        // Get EvaluationXQuestions
        [HttpGet]
        public IEnumerable<EvaluationXQuestion> GetEvaluationXQuestions()
        {
            return _evaluationXQuestionBusinessService.GetEvaluationXQuestions();
        }

        //Get one EvaluationXQuestion
        [HttpGet("{id}")]
        public EvaluationXQuestion? GetEvaluationXQuestion(long id)
        {
            return _evaluationXQuestionBusinessService.GetEvaluationXQuestion(id);
        }

        //Insert EvaluationXQuestion
        [HttpPost]
        public EvaluationXQuestion InsertEvaluationXQuestion(EvaluationXQuestion evaluationXQuestion)
        {
            return _evaluationXQuestionBusinessService.InsertEvaluationXQuestion(evaluationXQuestion);
        }

        //Update EvaluationXQuestion
        [HttpPut]
        public EvaluationXQuestion? UpdateEvaluationXQuestion(EvaluationXQuestion evaluationXQuestion)
        {
            return _evaluationXQuestionBusinessService.UpdateEvaluationXQuestion(evaluationXQuestion);
        }

        //Delete EvaluationXQuestion
        [HttpDelete("{id}")]
        public bool DeleteEvaluationXQuestion(long id)
        {
            return _evaluationXQuestionBusinessService.DeleteEvaluationXQuestion(id);
        }
    }
}