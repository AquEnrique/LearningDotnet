using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class ProfessionalSchoolDataService
    {
        private Context _context;
        public ProfessionalSchoolDataService(Context context)
        {
            _context = context;
        }

        // Get ProfessionalSchools
        public IEnumerable<ProfessionalSchool> GetProfessionalSchools()
        {
            return _context.ProfessionalSchools.ToList();
        }

        //Get one ProfessionalSchool
        public ProfessionalSchool? GetProfessionalSchool(long id)
        {
            var ProfessionalSchool = _context.ProfessionalSchools.Find(id);
            return ProfessionalSchool;
        }

        //Insert ProfessionalSchool
        public ProfessionalSchool InsertProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            _context.ProfessionalSchools.Add(professionalSchool);
            _context.SaveChanges();
            return professionalSchool;
        }

        //Update ProfessionalSchool
        public ProfessionalSchool? UpdateProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            var ProfessionalSchoolDbo = _context.ProfessionalSchools.Find(professionalSchool.IdProfSchool);

            if (ProfessionalSchoolDbo == null) return null;

            ProfessionalSchoolDbo.Name = professionalSchool.Name;
            _context.SaveChanges();
            return ProfessionalSchoolDbo;
        }

        //Delete ProfessionalSchool
        public bool DeleteProfessionalSchool(long id)
        {
            var ProfessionalSchoolDbo = _context.ProfessionalSchools.Find(id);
            if (ProfessionalSchoolDbo == null) return false;

            _context.ProfessionalSchools.Remove(ProfessionalSchoolDbo);
            _context.SaveChanges();
            return true;
        }
    }
}