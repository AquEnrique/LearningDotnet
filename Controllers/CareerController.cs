using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CareerController : ControllerBase
    {
        private CareerBusinessService _careerBusinessService;
        public CareerController(CareerBusinessService careerBusinessService)
        {
            _careerBusinessService = careerBusinessService;
        }

        // Get Careers
        [HttpGet]
        public IEnumerable<Career> GetCareers()
        {
            return _careerBusinessService.GetCareers();
        }

        //Get one Career
        [HttpGet("{id}")]
        public Career? GetCareer(long id)
        {
            return _careerBusinessService.GetCareer(id);
        }

        //Insert Career
        [HttpPost]
        public Career InsertCareer(Career career)
        {
            return _careerBusinessService.InsertCareer(career);
        }

        //Update Career
        [HttpPut]
        public Career? UpdateCareer(Career career)
        {
            return _careerBusinessService.UpdateCareer(career);
        }

        //Delete Career
        [HttpDelete("{id}")]
        public bool DeleteCareer(long id)
        {
            return _careerBusinessService.DeleteCareer(id);
        }
    }
}