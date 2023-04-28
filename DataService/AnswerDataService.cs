using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class AnswerDataService
    {
        private Context _context;
        public AnswerDataService(Context context)
        {
            _context = context;
        }

        // Get Answers
        public IEnumerable<Answer> GetAnswers()
        {
            return _context.Answers.ToList();
        }

        //Get one answer
        public Answer? GetAnswer(long id)
        {
            var answer = _context.Answers.Find(id);
            return answer;
        }

        //Insert Answer
        public Answer InsertAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        //Update answer
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