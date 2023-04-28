using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionAlternativeController : ControllerBase
    {
        private Context _context;
        public QuestionAlternativeController(Context context)
        {
            _context = context;
        }

        // Get QuestionAlternatives
        [HttpGet]
        public IEnumerable<QuestionAlternative> GetQuestionAlternatives()
        {
            return _context.QuestionAlternatives.ToList();
        }

        //Get one questionAlternative
        [HttpGet("{id}")]
        public QuestionAlternative? GetQuestionAlternative(long id)
        {
            var questionAlternative = _context.QuestionAlternatives.Find(id);
            return questionAlternative;
        }

        //Insert QuestionAlternative
        [HttpPost]
        public QuestionAlternative InsertQuestionAlternative(QuestionAlternative questionAlternative)
        {
            _context.QuestionAlternatives.Add(questionAlternative);
            _context.SaveChanges();
            return questionAlternative;
        }

        //Update questionAlternative
        [HttpPut]
        public QuestionAlternative? UpdateQuestionAlternative(QuestionAlternative questionAlternative)
        {
            var questionAlternativeDbo = _context.QuestionAlternatives.Find(questionAlternative.IdQuestionAlternative);

            if (questionAlternativeDbo == null) return null;

            questionAlternativeDbo.IdQuestionAlternative = questionAlternative.IdQuestionAlternative;
            questionAlternativeDbo.IdQuestion = questionAlternative.IdQuestion;
            questionAlternativeDbo.Alternative = questionAlternative.Alternative;
            questionAlternativeDbo.IsCorret = questionAlternative.IsCorret;
            questionAlternativeDbo.Question = questionAlternative.Question;

            _context.SaveChanges();
            return questionAlternativeDbo;
        }

        //Delete questionAlternative
        [HttpDelete("{id}")]
        public bool DeleteQuestionAlternative(long id)
        {
            var questionAlternativeDbo = _context.QuestionAlternatives.Find(id);
            if (questionAlternativeDbo == null) return false;

            _context.QuestionAlternatives.Remove(questionAlternativeDbo);
            _context.SaveChanges();
            return true;
        }

    }
}