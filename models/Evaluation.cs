using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class Evaluation
    {
        [Key]
        public long IdEvaluation { get; set; }
        public long? IdTeacherCourse { get; set; }
        public long? IdReview { get; set; }

        [ForeignKey(nameof(IdTeacherCourse))]
        public TeacherCourse? TeacherCourse {get;set;}

        [ForeignKey(nameof(IdReview))]
        public Review? Review {get;set;}

        public ICollection<EvaluationAssignment>? EvaluationAssignments {get;set;}
        public ICollection<EvaluationXQuestion>? EvaluationXQuestions {get;set;}

    }
}