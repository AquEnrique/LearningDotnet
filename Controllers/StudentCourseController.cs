using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentCourseController : ControllerBase
    {
        private StudentCourseBusinessService _studentCourseBusinessService;
        public StudentCourseController(StudentCourseBusinessService studentCourseBusinessService)
        {
            _studentCourseBusinessService = studentCourseBusinessService;
        }

        // Get StudentCourses
        [HttpGet]
        public IEnumerable<StudentCourse> GetStudentCourses()
        {
            return _studentCourseBusinessService.GetStudentCourses();
        }

        //Get one StudentCourse
        [HttpGet("{id}")]
        public StudentCourse? GetStudentCourse(long id)
        {
            return _studentCourseBusinessService.GetStudentCourse(id);
        }

        //Insert StudentCourse
        [HttpPost]
        public StudentCourse InsertStudentCourse(StudentCourse studentCourse)
        {
            return _studentCourseBusinessService.InsertStudentCourse(studentCourse);
        }

        //Update StudentCourse
        [HttpPut]
        public StudentCourse? UpdateStudentCourse(StudentCourse studentCourse)
        {
            return _studentCourseBusinessService.UpdateStudentCourse(studentCourse);
        }

        //Delete StudentCourse
        [HttpDelete("{id}")]
        public bool DeleteStudentCourse(long id)
        {
            return _studentCourseBusinessService.DeleteStudentCourse(id);
        }
    }
}