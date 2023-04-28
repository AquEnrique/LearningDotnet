using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private TeacherBusinessService _teacherBusinessService;
        public TeacherController(TeacherBusinessService teacherBusinessService)
        {
            _teacherBusinessService = teacherBusinessService;
        }

        // Get Teachers
        [HttpGet]
        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacherBusinessService.GetTeachers();
        }

        //Get one Teacher
        [HttpGet("{id}")]
        public Teacher? GetTeacher(long id)
        {
            return _teacherBusinessService.GetTeacher(id);
        }

        //Insert Teacher
        [HttpPost]
        public Teacher InsertTeacher(Teacher teacher)
        {
            return _teacherBusinessService.InsertTeacher(teacher);
        }

        //Update Teacher
        [HttpPut]
        public Teacher? UpdateTeacher(Teacher teacher)
        {
            return _teacherBusinessService.UpdateTeacher(teacher);
        }

        //Delete Teacher
        [HttpDelete("{id}")]
        public bool DeleteTeacher(long id)
        {
            return _teacherBusinessService.DeleteTeacher(id);
        }
    }
}