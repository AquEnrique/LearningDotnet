using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class TeacherCourseDataService
    {
        private Context _context;
        public TeacherCourseDataService(Context context)
        {
            _context = context;
        }

        // Get TeacherCourses
        public IEnumerable<TeacherCourse> GetTeacherCourses()
        {
            return _context.TeacherCourses.ToList();
        }

        //Get one teacherCourse
        public TeacherCourse? GetTeacherCourse(long id)
        {
            var teacherCourse = _context.TeacherCourses.Find(id);
            return teacherCourse;
        }

        //Insert TeacherCourse
        public TeacherCourse InsertTeacherCourse(TeacherCourse teacherCourse)
        {
            _context.TeacherCourses.Add(teacherCourse);
            _context.SaveChanges();
            return teacherCourse;
        }

        //Update teacherCourse
        public TeacherCourse? UpdateTeacherCourse(TeacherCourse teacherCourse)
        {
            var teacherCourseDbo = _context.TeacherCourses.Find(teacherCourse.IdTeacherCourse);

            if (teacherCourseDbo == null) return null;

            teacherCourseDbo.IdSemester = teacherCourse.IdSemester;
            teacherCourseDbo.IdTeacher = teacherCourse.IdTeacher;
            teacherCourseDbo.IdCourse = teacherCourse.IdCourse;

            teacherCourseDbo.Semester = teacherCourse.Semester;
            teacherCourseDbo.StudentCourses = teacherCourse.StudentCourses;
            teacherCourseDbo.Semester = teacherCourse.Semester;
            teacherCourseDbo.Teacher = teacherCourse.Teacher;
            teacherCourseDbo.StudentCourses = teacherCourse.StudentCourses;
            
            _context.SaveChanges();
            return teacherCourseDbo;
        }

        //Delete teacherCourse
        public bool DeleteTeacherCourse(long id)
        {
            var teacherCourseDbo = _context.TeacherCourses.Find(id);
            if (teacherCourseDbo == null) return false;

            _context.TeacherCourses.Remove(teacherCourseDbo);
            _context.SaveChanges();
            return true;
        }

    }
}