using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalSchoolController : ControllerBase
    {
        private ProfessionalSchoolBusinessService _professionalSchoolBusinessService;
        public ProfessionalSchoolController(ProfessionalSchoolBusinessService professionalSchoolBusinessService)
        {
            _professionalSchoolBusinessService = professionalSchoolBusinessService;
        }

        // Get ProfessionalSchools
        [HttpGet]
        public IEnumerable<ProfessionalSchool> GetProfessionalSchools()
        {
            return _professionalSchoolBusinessService.GetProfessionalSchools();
        }

        //Get one ProfessionalSchool
        [HttpGet("{id}")]
        public ProfessionalSchool? GetProfessionalSchool(long id)
        {
            return _professionalSchoolBusinessService.GetProfessionalSchool(id);
        }

        //Insert ProfessionalSchool
        [HttpPost]
        public ProfessionalSchool InsertProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            return _professionalSchoolBusinessService.InsertProfessionalSchool(professionalSchool);
        }

        //Update ProfessionalSchool
        [HttpPut]
        public ProfessionalSchool? UpdateProfessionalSchool(ProfessionalSchool professionalSchool)
        {
            return _professionalSchoolBusinessService.UpdateProfessionalSchool(professionalSchool);
        }

        //Delete ProfessionalSchool
        [HttpDelete("{id}")]
        public bool DeleteProfessionalSchool(long id)
        {
            return _professionalSchoolBusinessService.DeleteProfessionalSchool(id);
        }
    }
}