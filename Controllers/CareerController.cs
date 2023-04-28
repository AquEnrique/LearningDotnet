using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CareerController : ControllerBase
    {
        private Context _context;
        public CareerController(Context context)
        {
            _context = context;
        }

        // Get Careers
        [HttpGet]
        public IEnumerable<Career> GetCareers()
        {
            return _context.Careers.ToList();
        }

        //Get one career
        [HttpGet("{id}")]
        public Career? GetCareer(long id)
        {
            var career = _context.Careers.Find(id);
            return career;
        }

        //Insert Career
        [HttpPost]
        public Career InsertCareer(Career career)
        {
            _context.Careers.Add(career);
            _context.SaveChanges();
            return career;
        }

        //Update career
        [HttpPut]
        public Career? UpdateCareer(Career career)
        {
            var careerDbo = _context.Careers.Find(career.IdCareer);

            if (careerDbo == null) return null;

            careerDbo.Name = career.Name;
            careerDbo.IdProfSchool = career.IdProfSchool;
            _context.SaveChanges();
            return careerDbo;
        }

        //Delete career
        [HttpDelete("{id}")]
        public bool DeleteCareer(long id)
        {
            var careerDbo = _context.Careers.Find(id);
            if (careerDbo == null) return false;

            _context.Careers.Remove(careerDbo);
            _context.SaveChanges();
            return true;
        }

    }
}