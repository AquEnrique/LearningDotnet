using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class EvaluationAssignmentDataService
    {
        private Context _context;
        public EvaluationAssignmentDataService(Context context)
        {
            _context = context;
        }

        // Get EvaluationAssignments
        public IEnumerable<EvaluationAssignment> GetEvaluationAssignments()
        {
            return _context.EvaluationAssignments.ToList();
        }

        //Get one evaluationAssignment
        public EvaluationAssignment? GetEvaluationAssignment(long id)
        {
            var evaluationAssignment = _context.EvaluationAssignments.Find(id);
            return evaluationAssignment;
        }

        //Insert EvaluationAssignment
        public EvaluationAssignment InsertEvaluationAssignment(EvaluationAssignment evaluationAssignment)
        {
            _context.EvaluationAssignments.Add(evaluationAssignment);
            _context.SaveChanges();
            return evaluationAssignment;
        }

        //Update evaluationAssignment
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