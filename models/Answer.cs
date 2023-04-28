using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NotasApi.models
{
    public class Answer
    {
        [Key]
        public int IdAnswer { get; set; }
        public int IdEvaluationAssignment { get; set; }
        public int IdQuestionAlternative { get; set; }

        [ForeignKey(nameof(IdQuestionAlternative))]
        public Question? Question { get; set; }
    }
}