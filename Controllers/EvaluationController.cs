using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvaluationController : ControllerBase
    {
        private Context _context;
        public EvaluationController(Context context)
        {
            _context = context;
        }

        // Get Evaluations
        [HttpGet]
        public IEnumerable<Evaluation> GetEvaluations()
        {
            return _context.Evaluations.ToList();
        }

        //Get one evaluation
        [HttpGet("{id}")]
        public Evaluation? GetEvaluation(long id)
        {
            var evaluation = _context.Evaluations.Find(id);
            return evaluation;
        }

        //Insert Evaluation
        [HttpPost]
        public Evaluation InsertEvaluation(Evaluation evaluation)
        {
            _context.Evaluations.Add(evaluation);
            _context.SaveChanges();
            return evaluation;
        }

        //Update evaluation
        [HttpPut]
        public Evaluation? UpdateEvaluation(Evaluation evaluation)
        {
            var evaluationDbo = _context.Evaluations.Find(evaluation.IdEvaluation);

            if (evaluationDbo == null) return null;

            evaluationDbo.IdTeacherCourse = evaluation.IdTeacherCourse;
            evaluationDbo.IdReview = evaluation.IdReview;
            evaluationDbo.TeacherCourse = evaluation.TeacherCourse;
            evaluationDbo.Review = evaluation.Review;
            evaluationDbo.EvaluationAssignments = evaluation.EvaluationAssignments;
            evaluationDbo.EvaluationXQuestions = evaluation.EvaluationXQuestions;

            _context.SaveChanges();
            return evaluationDbo;
        }

        //Delete evaluation
        [HttpDelete("{id}")]
        public bool DeleteEvaluation(long id)
        {
            var evaluationDbo = _context.Evaluations.Find(id);
            if (evaluationDbo == null) return false;

            _context.Evaluations.Remove(evaluationDbo);
            _context.SaveChanges();
            return true;
        }

    }
}