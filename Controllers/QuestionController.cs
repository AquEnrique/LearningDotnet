using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private Context _context;
        public QuestionController(Context context)
        {
            _context = context;
        }

        // Get Questions
        [HttpGet]
        public IEnumerable<Question> GetQuestions()
        {
            return _context.Questions.ToList();
        }

        //Get one Question
        [HttpGet("{id}")]
        public Question? GetQuestion(long id)
        {
            var Question = _context.Questions.Find(id);
            return Question;
        }

        //Insert Question
        [HttpPost]
        public Question InsertQuestion(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question;
        }

        //Update Question
        [HttpPut]
        public Question? UpdateQuestion(Question question)
        {
            var QuestionDbo = _context.Questions.Find(question.IdQuestion);

            if (QuestionDbo == null) return null;

            QuestionDbo.Question_description = question.Question_description;
            QuestionDbo.TopicQuestion = question.TopicQuestion;
            _context.SaveChanges();
            return QuestionDbo;
        }

        //Delete Question
        [HttpDelete("{id}")]
        public bool DeleteQuestion(long id)
        {
            var QuestionDbo = _context.Questions.Find(id);
            if (QuestionDbo == null) return false;

            _context.Questions.Remove(QuestionDbo);
            _context.SaveChanges();
            return true;
        }
    }
}