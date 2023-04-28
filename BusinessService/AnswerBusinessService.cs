using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class AnswerBusinessService
    {
        private AnswerDataService _answerDataService;
        public AnswerBusinessService(AnswerDataService answerDataService)
        {
            _answerDataService = answerDataService;
        }

        // Get Answers
        public IEnumerable<Answer> GetAnswers()
        {
            return _answerDataService.GetAnswers();
        }

        //Get one Answer
        public Answer? GetAnswer(long id)
        {
            return _answerDataService.GetAnswer(id);
        }

        //Insert Answer
        public Answer InsertAnswer(Answer answer)
        {
            return _answerDataService.InsertAnswer(answer);
        }

        //Update Answer
        public Answer? UpdateAnswer(Answer answer)
        {
            return _answerDataService.UpdateAnswer(answer);
        }

        //Delete Answer
        public bool DeleteAnswer(long id)
        {
            return _answerDataService.DeleteAnswer(id);
        }
    }
}