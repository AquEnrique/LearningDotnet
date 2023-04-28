using Microsoft.AspNetCore.Mvc;
using NotasApi.models;
using NotasApi.BusinessService;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private StudentBusinessService _studentBusinessService;
        public StudentController(StudentBusinessService studentBusinessService)
        {
            _studentBusinessService = studentBusinessService;
        }

        //Get list of student
        [HttpGet]
        public IList<Student> GetStudents()
        {
            return _studentBusinessService.GetStudents();
        }
//         //Get one Student
//         [HttpGet]
//         public Student? GetStudent(long id)
//         {
//             return _studentBusinessService.GetStudent(id);
//         }

        //Insert Student
        [HttpPost]
        public Student InsertStudent(Student student)
        {
            return _studentBusinessService.InsertStudent(student);
        }

        //Update Student
        [HttpPut]
        public Student? UpdateStudent(Student student)
        {
            return _studentBusinessService.UpdateStudent(student);
        }

        //Delete Student
        [HttpDelete]
        public bool DeleteStudent(int id)
        {
            return _studentBusinessService.DeleteStudent(id);
        }
    }
}