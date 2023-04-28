using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private Context _context;
        public CourseController(Context context)
        {
            _context = context;
        }

        // Get Courses
        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }

        //Get one course
        [HttpGet("{id}")]
        public Course? GetCourse(long id)
        {
            var course = _context.Courses.Find(id);
            return course;
        }

        //Insert Course
        [HttpPost]
        public Course InsertCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        //Update course
        [HttpPut]
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
        [HttpDelete("{id}")]
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