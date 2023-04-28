using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalSchoolController : ControllerBase
    {
        private Context _context;
        public ProfessionalSchoolController(Context context)
        {
            _context = context;
        }

        // Get ProfessionalSchools
        [HttpGet]
        public IEnumerable<ProfessionalSchool> GetProfessionalSchools()
        {
            return _context.ProfessionalSchools.ToList();
        }

        //Get one ProfessionalSchool
        [HttpGet("{id}")]
        public ProfessionalSchool? GetProfessionalSchool(long id)
        {
            var ProfessionalSchool = _context.ProfessionalSchools.Find(id);
            return ProfessionalSchool;
        }

        //Insert ProfessionalSchool
        [HttpPost]
        public ProfessionalSchool InsertProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            _context.ProfessionalSchools.Add(professionalSchool);
            _context.SaveChanges();
            return professionalSchool;
        }

        //Update ProfessionalSchool
        [HttpPut]
        public ProfessionalSchool? UpdateProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            var ProfessionalSchoolDbo = _context.ProfessionalSchools.Find(professionalSchool.IdProfSchool);

            if (ProfessionalSchoolDbo == null) return null;

            ProfessionalSchoolDbo.Name = professionalSchool.Name;
            _context.SaveChanges();
            return ProfessionalSchoolDbo;
        }

        //Delete ProfessionalSchool
        [HttpDelete("{id}")]
        public bool DeleteProfessionalSchool(int id)
        {
            var ProfessionalSchoolDbo = _context.ProfessionalSchools.Find(id);
            if (ProfessionalSchoolDbo == null) return false;

            _context.ProfessionalSchools.Remove(ProfessionalSchoolDbo);
            _context.SaveChanges();
            return true;
        }
    }
}