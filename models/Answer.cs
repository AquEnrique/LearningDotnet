using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NotasApi.models
{
    public class Answer
    {
        [Key]
        public long IdAnswer { get; set; }
        public long IdEvaluationAssignment { get; set; }
        public long IdQuestionAlternative { get; set; }

        [ForeignKey(nameof(IdQuestionAlternative))]
        public Question? Question { get; set; }
    }
}