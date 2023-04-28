using Microsoft.AspNetCore.Mvc;
using NotasApi.models;
using NotasApi.BusinessService;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SemesterController : ControllerBase
    {
        private SemesterBusinessService _semesterBusinessService;
        public SemesterController(SemesterBusinessService semesterBusinessService)
        {
            _semesterBusinessService = semesterBusinessService;
        }

        // Get Semesters
        [HttpGet]
        public IEnumerable<Semester> GetSemesters()
        {
            return _semesterBusinessService.GetSemesters();
        }

        //Get one Semester
        [HttpGet("{id}")]
        public Semester? GetSemester(long id)
        {
            return _semesterBusinessService.GetSemester(id);
        }

        //Insert Semester
        [HttpPost]
        public Semester InsertSemester(Semester semester)
        {
            return _semesterBusinessService.InsertSemester(semester);
        }

        //Update Semester
        [HttpPut]
        public Semester? UpdateSemester(Semester semester)
        {
            return _semesterBusinessService.UpdateSemester(semester);
        }

        //Delete Semester
        [HttpDelete("{id}")]
        public bool DeleteSemester(long id)
        {
            return _semesterBusinessService.DeleteSemester(id);
        }
    }
}