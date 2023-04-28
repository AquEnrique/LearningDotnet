using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class QuestionAlternativeBusinessService
    {
        private QuestionAlternativeDataService _questionAlternativeDataService;
        public QuestionAlternativeBusinessService(QuestionAlternativeDataService questionAlternativeDataService)
        {
            _questionAlternativeDataService = questionAlternativeDataService;
        }

        // Get QuestionAlternatives
        public IEnumerable<QuestionAlternative> GetQuestionAlternatives()
        {
            return _questionAlternativeDataService.GetQuestionAlternatives();
        }

        //Get one QuestionAlternative
        public QuestionAlternative? GetQuestionAlternative(long id)
        {
            return _questionAlternativeDataService.GetQuestionAlternative(id);
        }

        //Insert QuestionAlternative
        public QuestionAlternative InsertQuestionAlternative(QuestionAlternative questionAlternative)
        {
            return _questionAlternativeDataService.InsertQuestionAlternative(questionAlternative);
        }

        //Update QuestionAlternative
        public QuestionAlternative? UpdateQuestionAlternative(QuestionAlternative questionAlternative)
        {
            return _questionAlternativeDataService.UpdateQuestionAlternative(questionAlternative);
        }

        //Delete QuestionAlternative
        public bool DeleteQuestionAlternative(long id)
        {
            return _questionAlternativeDataService.DeleteQuestionAlternative(id);
        }
    }
}