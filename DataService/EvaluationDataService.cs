using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class EvaluationDataService
    {
        private Context _context;
        public EvaluationDataService(Context context)
        {
            _context = context;
        }

        // Get Evaluations
        public IEnumerable<Evaluation> GetEvaluations()
        {
            return _context.Evaluations.ToList();
        }

        //Get one evaluation
        public Evaluation? GetEvaluation(long id)
        {
            var evaluation = _context.Evaluations.Find(id);
            return evaluation;
        }

        //Insert Evaluation
        public Evaluation InsertEvaluation(Evaluation evaluation)
        {
            _context.Evaluations.Add(evaluation);
            _context.SaveChanges();
            return evaluation;
        }

        //Update evaluation
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