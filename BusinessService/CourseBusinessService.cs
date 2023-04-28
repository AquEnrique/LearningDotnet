using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class CourseBusinessService
    {
        private CourseDataService _courseDataService;
        public CourseBusinessService(CourseDataService courseDataService)
        {
            _courseDataService = courseDataService;
        }

        // Get Courses
        public IEnumerable<Course> GetCourses()
        {
            return _courseDataService.GetCourses();
        }

        //Get one Course
        public Course? GetCourse(long id)
        {
            return _courseDataService.GetCourse(id);
        }

        //Insert Course
        public Course InsertCourse(Course course)
        {
            return _courseDataService.InsertCourse(course);
        }

        //Update Course
        public Course? UpdateCourse(Course course)
        {
            return _courseDataService.UpdateCourse(course);
        }

        //Delete Course
        public bool DeleteCourse(long id)
        {
            return _courseDataService.DeleteCourse(id);
        }
    }
}