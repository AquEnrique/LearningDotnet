using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class QuestionBusinessService
    {
        private QuestionDataService _questionDataService;
        public QuestionBusinessService(QuestionDataService questionDataService)
        {
            _questionDataService = questionDataService;
        }

        // Get Questions
        public IEnumerable<Question> GetQuestions()
        {
            return _questionDataService.GetQuestions();
        }

        //Get one Question
        public Question? GetQuestion(long id)
        {
            return _questionDataService.GetQuestion(id);
        }

        //Insert Question
        public Question InsertQuestion(Question question)
        {
            return _questionDataService.InsertQuestion(question);
        }

        //Update Question
        public Question? UpdateQuestion(Question question)
        {
            return _questionDataService.UpdateQuestion(question);
        }

        //Delete Question
        public bool DeleteQuestion(long id)
        {
            return _questionDataService.DeleteQuestion(id);
        }
    }
}