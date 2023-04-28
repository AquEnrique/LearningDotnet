using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class Review
    {
        [Key]
        public long IdReview { get; set; }
        public long IdStudent { get; set; }
        public string TopicReview { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long ReviewInterval { get; set; }

        [ForeignKey(nameof(IdStudent))]
        public Student? Student { get; set; }

        public ICollection<Evaluation>? Evaluations {get;set;}
    }
}