using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvaluationController : ControllerBase
    {
        private EvaluationBusinessService _evaluationBusinessService;
        public EvaluationController(EvaluationBusinessService evaluationBusinessService)
        {
            _evaluationBusinessService = evaluationBusinessService;
        }

        // Get Evaluations
        [HttpGet]
        public IEnumerable<Evaluation> GetEvaluations()
        {
            return _evaluationBusinessService.GetEvaluations();
        }

        //Get one Evaluation
        [HttpGet("{id}")]
        public Evaluation? GetEvaluation(long id)
        {
            return _evaluationBusinessService.GetEvaluation(id);
        }

        //Insert Evaluation
        [HttpPost]
        public Evaluation InsertEvaluation(Evaluation evaluation)
        {
            return _evaluationBusinessService.InsertEvaluation(evaluation);
        }

        //Update Evaluation
        [HttpPut]
        public Evaluation? UpdateEvaluation(Evaluation evaluation)
        {
            return _evaluationBusinessService.UpdateEvaluation(evaluation);
        }

        //Delete Evaluation
        [HttpDelete("{id}")]
        public bool DeleteEvaluation(long id)
        {
            return _evaluationBusinessService.DeleteEvaluation(id);
        }
    }
}