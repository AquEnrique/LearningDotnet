using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class EvaluationAssignment
    {
        [Key]
        public int IdEvaluationAssignment { get; set; }
        public int IdEvaluation { get; set; }
        public int IdStudent { get; set; }
        public float? Note { get; set; }

        [ForeignKey(nameof(IdStudent))]
        public Student? Student { get; set; }

        public ICollection<Answer>? Answers {get;set;}
    }
}