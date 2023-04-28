using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasApi.BusinessService;
using NotasApi.models;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private CourseBusinessService _courseBusinessService;
        public CourseController(CourseBusinessService courseBusinessService)
        {
            _courseBusinessService = courseBusinessService;
        }

        // Get Courses
        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _courseBusinessService.GetCourses();
        }

        //Get one Course
        [HttpGet("{id}")]
        public Course? GetCourse(long id)
        {
            return _courseBusinessService.GetCourse(id);
        }

        //Insert Course
        [HttpPost]
        public Course InsertCourse(Course course)
        {
            return _courseBusinessService.InsertCourse(course);
        }

        //Update Course
        [HttpPut]
        public Course? UpdateCourse(Course course)
        {
            return _courseBusinessService.UpdateCourse(course);
        }

        //Delete Course
        [HttpDelete("{id}")]
        public bool DeleteCourse(long id)
        {
            return _courseBusinessService.DeleteCourse(id);
        }
    }
}