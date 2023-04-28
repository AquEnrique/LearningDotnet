using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentCourseController : ControllerBase
    {
        private Context _context;
        public StudentCourseController(Context context)
        {
            _context = context;
        }

        // Get StudentCourses
        [HttpGet]
        public IEnumerable<StudentCourse> GetStudentCourses()
        {
            return _context.StudentCourses.ToList();
        }

        //Get one studentCourse
        [HttpGet("{id}")]
        public StudentCourse? GetStudentCourse(long id)
        {
            var studentCourse = _context.StudentCourses.Find(id);
            return studentCourse;
        }

        //Insert StudentCourse
        [HttpPost]
        public StudentCourse InsertStudentCourse(StudentCourse studentCourse)
        {
            _context.StudentCourses.Add(studentCourse);
            _context.SaveChanges();
            return studentCourse;
        }

        //| studentCourse
        [HttpPut]
        public StudentCourse? UpdateStudentCourse(StudentCourse studentCourse)
        {
            var studentCourseDbo = _context.StudentCourses.Find(studentCourse.IdStudentCourse);

            if (studentCourseDbo == null) return null;

            studentCourseDbo.IdStudent = studentCourse.IdStudent;
            studentCourseDbo.IdTeacherCourse = studentCourse.IdTeacherCourse;
            studentCourseDbo.Grade1 = studentCourse.Grade1;
            studentCourseDbo.Grade2 = studentCourse.Grade2;
            studentCourseDbo.Grade3 = studentCourse.Grade3;
            studentCourseDbo.Student = studentCourse.Student;
            studentCourseDbo.TeacherCourse = studentCourse.TeacherCourse;

            _context.SaveChanges();
            return studentCourseDbo;
        }

        //Delete studentCourse
        [HttpDelete("{id}")]
        public bool DeleteStudentCourse(long id)
        {
            var studentCourseDbo = _context.StudentCourses.Find(id);
            if (studentCourseDbo == null) return false;

            _context.StudentCourses.Remove(studentCourseDbo);
            _context.SaveChanges();
            return true;
        }

    }
}