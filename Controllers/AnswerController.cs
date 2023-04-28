using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController : ControllerBase
    {
        private Context _context;
        public AnswerController(Context context)
        {
            _context = context;
        }

        // Get Answers
        [HttpGet]
        public IEnumerable<Answer> GetAnswers()
        {
            return _context.Answers.ToList();
        }

        //Get one answer
        [HttpGet("{id}")]
        public Answer? GetAnswer(long id)
        {
            var answer = _context.Answers.Find(id);
            return answer;
        }

        //Insert Answer
        [HttpPost]
        public Answer InsertAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        //Update answer
        [HttpPut]
        public Answer? UpdateAnswer(Answer answer)
        {
            var answerDbo = _context.Answers.Find(answer.IdAnswer);

            if (answerDbo == null) return null;

            /*answerDbo.Name = answer.Name;
            answerDbo.IdProfSchool = answer.IdProfSchool;*/
            _context.SaveChanges();
            return answerDbo;
        }

        //Delete answer
        [HttpDelete("{id}")]
        public bool DeleteAnswer(long id)
        {
            var answerDbo = _context.Answers.Find(id);
            if (answerDbo == null) return false;

            _context.Answers.Remove(answerDbo);
            _context.SaveChanges();
            return true;
        }

    }
}