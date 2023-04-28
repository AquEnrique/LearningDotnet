using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvaluationAssignmentController : ControllerBase
    {
        private EvaluationAssignmentBusinessService _evaluationAssignmentBusinessService;
        public EvaluationAssignmentController(EvaluationAssignmentBusinessService evaluationAssignmentBusinessService)
        {
            _evaluationAssignmentBusinessService = evaluationAssignmentBusinessService;
        }

        // Get EvaluationAssignments
        [HttpGet]
        public IEnumerable<EvaluationAssignment> GetEvaluationAssignments()
        {
            return _evaluationAssignmentBusinessService.GetEvaluationAssignments();
        }

        //Get one EvaluationAssignment
        [HttpGet("{id}")]
        public EvaluationAssignment? GetEvaluationAssignment(long id)
        {
            return _evaluationAssignmentBusinessService.GetEvaluationAssignment(id);
        }

        //Insert EvaluationAssignment
        [HttpPost]
        public EvaluationAssignment InsertEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            return _evaluationAssignmentBusinessService.InsertEvaluationAssignment(evaluationAssignment);
        }

        //Update EvaluationAssignment
        [HttpPut]
        public EvaluationAssignment? UpdateEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            return _evaluationAssignmentBusinessService.UpdateEvaluationAssignment(evaluationAssignment);
        }

        //Delete EvaluationAssignment
        [HttpDelete("{id}")]
        public bool DeleteEvaluationAssignment(long id)
        {
            return _evaluationAssignmentBusinessService.DeleteEvaluationAssignment(id);
        }
    }
}