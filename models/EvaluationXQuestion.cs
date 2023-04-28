using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class EvaluationXQuestion
    {
        [Key]
        public long IdEvalXQuestion { get; set; }
        public long IdEvaluation { get; set; }
        public long IdQuestion { get; set; }

        [ForeignKey(nameof(IdEvaluation))]
        public Evaluation? Evaluation { get; set; }

        [ForeignKey(nameof(IdQuestion))]
        public Question? Question { get; set; }
    }
}