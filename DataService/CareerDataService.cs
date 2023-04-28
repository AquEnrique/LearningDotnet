using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class CareerDataService
    {
        private Context _context;
        public CareerDataService(Context context)
        {
            _context = context;
        }

        // Get Careers
        public IEnumerable<Career> GetCareers()
        {
            return _context.Careers.ToList();
        }

        //Get one career
        public Career? GetCareer(long id)
        {
            var career = _context.Careers.Find(id);
            return career;
        }

        //Insert Career
        public Career InsertCareer(Career career)
        {
            _context.Careers.Add(career);
            _context.SaveChanges();
            return career;
        }

        //Update career
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