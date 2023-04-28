using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NotasApi.models;
using NotasApi.DataService;

namespace NotasApi.BusinessService
{
    public class ProfessionalSchoolBusinessService
    {
        private ProfessionalSchoolDataService _professionalSchoolDataService;
        public ProfessionalSchoolBusinessService(ProfessionalSchoolDataService professionalSchoolDataService)
        {
            _professionalSchoolDataService = professionalSchoolDataService;
        }

        // Get ProfessionalSchools
        public IEnumerable<ProfessionalSchool> GetProfessionalSchools()
        {
            return _professionalSchoolDataService.GetProfessionalSchools();
        }

        //Get one ProfessionalSchool
        public ProfessionalSchool? GetProfessionalSchool(long id)
        {
            return _professionalSchoolDataService.GetProfessionalSchool(id);
        }

        //Insert ProfessionalSchool
        public ProfessionalSchool InsertProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            return _professionalSchoolDataService.InsertProfessionalSchool(professionalSchool);
        }

        //Update ProfessionalSchool
        public ProfessionalSchool? UpdateProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            return _professionalSchoolDataService.UpdateProfessionalSchool(professionalSchool);
        }

        //Delete ProfessionalSchool
        public bool DeleteProfessionalSchool(long id)
        {
            return _professionalSchoolDataService.DeleteProfessionalSchool(id);
        }
    }
}