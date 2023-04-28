using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class StudentCourseDataService
    {
        private Context _context;
        public StudentCourseDataService(Context context)
        {
            _context = context;
        }

        // Get StudentCourses
        public IEnumerable<StudentCourse> GetStudentCourses()
        {
            return _context.StudentCourses.ToList();
        }

        //Get one studentCourse
        public StudentCourse? GetStudentCourse(long id)
        {
            var studentCourse = _context.StudentCourses.Find(id);
            return studentCourse;
        }

        //Insert StudentCourse
        public StudentCourse InsertStudentCourse(StudentCourse studentCourse)
        {
            _context.StudentCourses.Add(studentCourse);
            _context.SaveChanges();
            return studentCourse;
        }

        //| studentCourse
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