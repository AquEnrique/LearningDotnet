using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvaluationAssignmentController : ControllerBase
    {
        private Context _context;
        public EvaluationAssignmentController(Context context)
        {
            _context = context;
        }

        // Get EvaluationAssignments
        [HttpGet]
        public IEnumerable<EvaluationAssignment> GetEvaluationAssignments()
        {
            return _context.EvaluationAssignments.ToList();
        }

        //Get one evaluationAssignment
        [HttpGet("{id}")]
        public EvaluationAssignment? GetEvaluationAssignment(long id)
        {
            var evaluationAssignment = _context.EvaluationAssignments.Find(id);
            return evaluationAssignment;
        }

        //Insert EvaluationAssignment
        [HttpPost]
        public EvaluationAssignment InsertEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            _context.EvaluationAssignments.Add(evaluationAssignment);
            _context.SaveChanges();
            return evaluationAssignment;
        }

        //Update evaluationAssignment
        [HttpPut]
        public EvaluationAssignment? UpdateEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            var evaluationAssignmentDbo = _context.EvaluationAssignments.Find(evaluationAssignment.IdEvaluationAssignment);

            if (evaluationAssignmentDbo == null) return null;

            /*evaluationAssignmentDbo.Name = evaluationAssignment.Name;
            evaluationAssignmentDbo.IdProfSchool = evaluationAssignment.IdProfSchool;*/
            _context.SaveChanges();
            return evaluationAssignmentDbo;
        }

        //Delete evaluationAssignment
        [HttpDelete("{id}")]
        public bool DeleteEvaluationAssignment(long id)
        {
            var evaluationAssignmentDbo = _context.EvaluationAssignments.Find(id);
            if (evaluationAssignmentDbo == null) return false;

            _context.EvaluationAssignments.Remove(evaluationAssignmentDbo);
            _context.SaveChanges();
            return true;
        }

    }
}