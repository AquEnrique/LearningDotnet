using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class EvaluationXQuestion
    {
        [Key]
        public int IdEvalXQuestion { get; set; }
        public int IdEvaluation { get; set; }
        public int IdQuestion { get; set; }

        [ForeignKey(nameof(IdEvaluation))]
        public Evaluation? Evaluation { get; set; }

        [ForeignKey(nameof(IdQuestion))]
        public Question? Question { get; set; }
    }
}