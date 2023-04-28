using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class EvaluationBusinessService
    {
        private EvaluationDataService _evaluationDataService;
        public EvaluationBusinessService(EvaluationDataService evaluationDataService)
        {
            _evaluationDataService = evaluationDataService;
        }

        // Get Evaluations
        public IEnumerable<Evaluation> GetEvaluations()
        {
            return _evaluationDataService.GetEvaluations();
        }

        //Get one Evaluation
        public Evaluation? GetEvaluation(long id)
        {
            return _evaluationDataService.GetEvaluation(id);
        }

        //Insert Evaluation
        public Evaluation InsertEvaluation(Evaluation evaluation)
        {
            return _evaluationDataService.InsertEvaluation(evaluation);
        }

        //Update Evaluation
        public Evaluation? UpdateEvaluation(Evaluation evaluation)
        {
            return _evaluationDataService.UpdateEvaluation(evaluation);
        }

        //Delete Evaluation
        public bool DeleteEvaluation(long id)
        {
            return _evaluationDataService.DeleteEvaluation(id);
        }
    }
}