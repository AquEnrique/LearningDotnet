using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SemesterController : ControllerBase
    {
        private Context _context;
        public SemesterController(Context context)
        {
            _context = context;
        }

        // Get Semesters
        [HttpGet]
        public IEnumerable<Semester> GetSemesters()
        {
            return _context.Semesters.ToList();
        }

        //Get one Semester
        [HttpGet("{id}")]
        public Semester? GetSemester(long id)
        {
            var Semester = _context.Semesters.Find(id);
            return Semester;
        }

        //Insert Semester
        [HttpPost]
        public Semester InsertSemester(Semester semester)
        {
            _context.Semesters.Add(semester);
            _context.SaveChanges();
            return semester;
        }

        //Update Semester
        [HttpPut]
        public Semester? UpdateSemester(Semester semester)
        {
            var SemesterDbo = _context.Semesters.Find(semester.IdSemester);

            if (SemesterDbo == null) return null;

            SemesterDbo.NameSemester = semester.NameSemester;
            _context.SaveChanges();
            return SemesterDbo;
        }

        //Delete Semester
        [HttpDelete("{id}")]
        public bool DeleteSemester(long id)
        {
            var SemesterDbo = _context.Semesters.Find(id);
            if (SemesterDbo == null) return false;

            _context.Semesters.Remove(SemesterDbo);
            _context.SaveChanges();
            return true;
        }
    }
}