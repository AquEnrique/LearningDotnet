using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class EvaluationAssignment
    {
        [Key]
        public long IdEvaluationAssignment { get; set; }
        public long IdEvaluation { get; set; }
        public long IdStudent { get; set; }
        public float? Note { get; set; }

        [ForeignKey(nameof(IdStudent))]
        public Student? Student { get; set; }

        public ICollection<Answer>? Answers {get;set;}
    }
}