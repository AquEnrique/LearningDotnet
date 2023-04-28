using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class CourseDataService
    {
        private Context _context;
        public CourseDataService(Context context)
        {
            _context = context;
        }

        // Get Courses
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }

        //Get one course
        public Course? GetCourse(long id)
        {
            var course = _context.Courses.Find(id);
            return course;
        }

        //Insert Course
        public Course InsertCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        //Update course
        public Course? UpdateCourse(Course course)
        {
            var courseDbo = _context.Courses.Find(course.IdCourse);

            if (courseDbo == null) return null;

            courseDbo.Name = course.Name;
            courseDbo.IdCareer = course.IdCareer;
            courseDbo.TeacherCourses = course.TeacherCourses;

            _context.SaveChanges();
            return courseDbo;
        }

        //Delete course
        public bool DeleteCourse(long id)
        {
            var courseDbo = _context.Courses.Find(id);
            if (courseDbo == null) return false;

            _context.Courses.Remove(courseDbo);
            _context.SaveChanges();
            return true;
        }

    }
}