using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class EvaluationXQuestionBusinessService
    {
        private EvaluationXQuestionDataService _evaluationXQuestionDataService;
        public EvaluationXQuestionBusinessService(EvaluationXQuestionDataService evaluationXQuestionDataService)
        {
            _evaluationXQuestionDataService = evaluationXQuestionDataService;
        }

        // Get EvaluationXQuestions
        public IEnumerable<EvaluationXQuestion> GetEvaluationXQuestions()
        {
            return _evaluationXQuestionDataService.GetEvaluationXQuestions();
        }

        //Get one EvaluationXQuestion
        public EvaluationXQuestion? GetEvaluationXQuestion(long id)
        {
            return _evaluationXQuestionDataService.GetEvaluationXQuestion(id);
        }

        //Insert EvaluationXQuestion
        public EvaluationXQuestion InsertEvaluationXQuestion(EvaluationXQuestion evaluationXQuestion)
        {
            return _evaluationXQuestionDataService.InsertEvaluationXQuestion(evaluationXQuestion);
        }

        //Update EvaluationXQuestion
        public EvaluationXQuestion? UpdateEvaluationXQuestion(EvaluationXQuestion evaluationXQuestion)
        {
            return _evaluationXQuestionDataService.UpdateEvaluationXQuestion(evaluationXQuestion);
        }

        //Delete EvaluationXQuestion
        public bool DeleteEvaluationXQuestion(long id)
        {
            return _evaluationXQuestionDataService.DeleteEvaluationXQuestion(id);
        }
    }
}