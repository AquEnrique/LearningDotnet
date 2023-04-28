using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class CareerBusinessService
    {
        private CareerDataService _careerDataService;
        public CareerBusinessService(CareerDataService careerDataService)
        {
            _careerDataService = careerDataService;
        }

        // Get Careers
        public IEnumerable<Career> GetCareers()
        {
            return _careerDataService.GetCareers();
        }

        //Get one Career
        public Career? GetCareer(long id)
        {
            return _careerDataService.GetCareer(id);
        }

        //Insert Career
        public Career InsertCareer(Career career)
        {
            return _careerDataService.InsertCareer(career);
        }

        //Update Career
        public Career? UpdateCareer(Career career)
        {
            return _careerDataService.UpdateCareer(career);
        }

        //Delete Career
        public bool DeleteCareer(long id)
        {
            return _careerDataService.DeleteCareer(id);
        }
    }
}