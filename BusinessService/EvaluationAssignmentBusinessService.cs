using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class EvaluationAssignmentBusinessService
    {
        private EvaluationAssignmentDataService _evaluationAssignmentDataService;
        public EvaluationAssignmentBusinessService(EvaluationAssignmentDataService evaluationAssignmentDataService)
        {
            _evaluationAssignmentDataService = evaluationAssignmentDataService;
        }

        // Get EvaluationAssignments
        public IEnumerable<EvaluationAssignment> GetEvaluationAssignments()
        {
            return _evaluationAssignmentDataService.GetEvaluationAssignments();
        }

        //Get one EvaluationAssignment
        public EvaluationAssignment? GetEvaluationAssignment(long id)
        {
            return _evaluationAssignmentDataService.GetEvaluationAssignment(id);
        }

        //Insert EvaluationAssignment
        public EvaluationAssignment InsertEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            return _evaluationAssignmentDataService.InsertEvaluationAssignment(evaluationAssignment);
        }

        //Update EvaluationAssignment
        public EvaluationAssignment? UpdateEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            return _evaluationAssignmentDataService.UpdateEvaluationAssignment(evaluationAssignment);
        }

        //Delete EvaluationAssignment
        public bool DeleteEvaluationAssignment(long id)
        {
            return _evaluationAssignmentDataService.DeleteEvaluationAssignment(id);
        }
    }
}