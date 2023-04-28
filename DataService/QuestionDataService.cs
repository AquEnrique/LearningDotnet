using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class QuestionDataService
    {
        private Context _context;
        public QuestionDataService(Context context)
        {
            _context = context;
        }

        // Get Questions
        public IEnumerable<Question> GetQuestions()
        {
            return _context.Questions.ToList();
        }

        //Get one Question
        public Question? GetQuestion(long id)
        {
            var Question = _context.Questions.Find(id);
            return Question;
        }

        //Insert Question
        public Question InsertQuestion(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question;
        }

        //Update Question
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