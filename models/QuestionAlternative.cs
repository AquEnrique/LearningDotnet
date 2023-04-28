using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class QuestionAlternative
    {
        [Key]
        public int IdQuestionAlternative { get; set; }
        public int IdQuestion { get; set; }
        public string Alternative { get; set; }
        public bool IsCorret { get; set; }

        [ForeignKey(nameof(IdQuestion))]
        public Question? Question { get; set; }
    }
}