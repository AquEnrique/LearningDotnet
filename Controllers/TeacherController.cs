using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private Context _context;
        public TeacherController(Context context)
        {
            _context = context;
        }

        // Get Teachers
        [HttpGet]
        public IEnumerable<Teacher> GetTeachers()
        {
            return _context.Teachers.ToList();
        }

        //Get one Teacher
        [HttpGet("{id}")]
        public Teacher? GetTeacher(long id)
        {
            var Teacher = _context.Teachers.Find(id);
            return Teacher;
        }

        //Insert Teacher
        [HttpPost]
        public Teacher InsertTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        //Update Teacher
        [HttpPut]
        public Teacher? UpdateTeacher(Teacher teacher)
        {
            var TeacherDbo = _context.Teachers.Find(teacher.IdTeacher);

            if (TeacherDbo == null) return null;

            TeacherDbo.Name = teacher.Name;
            TeacherDbo.LastName = teacher.LastName;
            _context.SaveChanges();
            return TeacherDbo;
        }

        //Delete Teacher
        [HttpDelete("{id}")]
        public bool DeleteTeacher(long id)
        {
            var TeacherDbo = _context.Teachers.Find(id);
            if (TeacherDbo == null) return false;

            _context.Teachers.Remove(TeacherDbo);
            _context.SaveChanges();
            return true;
        }
    }
}