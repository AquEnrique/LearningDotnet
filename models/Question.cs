using System.ComponentModel.DataAnnotations;

namespace NotasApi.models
{
    public class Question
    {
        [Key]
        public int IdQuestion { get; set; }
        public string Question_description { get; set; }
        public string TopicQuestion { get; set; }

        public ICollection<EvaluationXQuestion>? EvaluationXQuestions {get;set;}
        public ICollection<QuestionAlternative>? QuestionAlternatives {get;set;}
    }
}