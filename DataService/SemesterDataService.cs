using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class SemesterDataService
    {
        private Context _context;
        public SemesterDataService(Context context)
        {
            _context = context;
        }

        // Get Semesters
        public IEnumerable<Semester> GetSemesters()
        {
            return _context.Semesters.ToList();
        }

        //Get one Semester
        public Semester? GetSemester(long id)
        {
            var Semester = _context.Semesters.Find(id);
            return Semester;
        }

        //Insert Semester
        public Semester InsertSemester(Semester semester)
        {
            _context.Semesters.Add(semester);
            _context.SaveChanges();
            return semester;
        }

        //Update Semester
        public Semester? UpdateSemester(Semester semester)
        {
            var SemesterDbo = _context.Semesters.Find(semester.IdSemester);

            if (SemesterDbo == null) return null;

            SemesterDbo.NameSemester = semester.NameSemester;
            _context.SaveChanges();
            return SemesterDbo;
        }

        //Delete Semester
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