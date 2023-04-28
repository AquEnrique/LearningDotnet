using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class EvaluationXQuestionDataService
    {
        private Context _context;
        public EvaluationXQuestionDataService(Context context)
        {
            _context = context;
        }

        // Get EvaluationXQuestions
        public IEnumerable<EvaluationXQuestion> GetEvaluationXQuestions()
        {
            return _context.EvaluationXQuestions.ToList();
        }

        //Get one evaluationXQuestion
        public EvaluationXQuestion? GetEvaluationXQuestion(long id)
        {
            var evaluationXQuestion = _context.EvaluationXQuestions.Find(id);
            return evaluationXQuestion;
        }

        //Insert EvaluationXQuestion
        public EvaluationXQuestion InsertEvaluationXQuestion(EvaluationXQuestion evaluationXQuestion)
        {
            _context.EvaluationXQuestions.Add(evaluationXQuestion);
            _context.SaveChanges();
            return evaluationXQuestion;
        }

        //Update evaluationXQuestion
        public EvaluationXQuestion? UpdateEvaluationXQuestion(EvaluationXQuestion evaluationXQuestion)
        {
            var evaluationXQuestionDbo = _context.EvaluationXQuestions.Find(evaluationXQuestion.IdEvalXQuestion);

            if (evaluationXQuestionDbo == null) return null;

            evaluationXQuestionDbo.IdEvalXQuestion = evaluationXQuestion.IdEvalXQuestion;
            evaluationXQuestionDbo.IdEvaluation = evaluationXQuestion.IdEvaluation;
            evaluationXQuestionDbo.IdQuestion = evaluationXQuestion.IdQuestion;
            evaluationXQuestionDbo.Evaluation = evaluationXQuestion.Evaluation;
            evaluationXQuestionDbo.Question = evaluationXQuestion.Question;

            _context.SaveChanges();
            return evaluationXQuestionDbo;
        }

        //Delete evaluationXQuestion
        public bool DeleteEvaluationXQuestion(long id)
        {
            var evaluationXQuestionDbo = _context.EvaluationXQuestions.Find(id);
            if (evaluationXQuestionDbo == null) return false;

            _context.EvaluationXQuestions.Remove(evaluationXQuestionDbo);
            _context.SaveChanges();
            return true;
        }

    }
}