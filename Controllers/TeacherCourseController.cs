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
    public class TeacherCourseController : ControllerBase
    {
        private TeacherCourseBusinessService _teacherCourseBusinessService;
        public TeacherCourseController(TeacherCourseBusinessService teacherCourseBusinessService)
        {
            _teacherCourseBusinessService = teacherCourseBusinessService;
        }

        // Get TeacherCourses
        [HttpGet]
        public IEnumerable<TeacherCourse> GetTeacherCourses()
        {
            return _teacherCourseBusinessService.GetTeacherCourses();
        }

        //Get one TeacherCourse
        [HttpGet("{id}")]
        public TeacherCourse? GetTeacherCourse(long id)
        {
            return _teacherCourseBusinessService.GetTeacherCourse(id);
        }

        //Insert TeacherCourse
        [HttpPost]
        public TeacherCourse InsertTeacherCourse(TeacherCourse teacherCourse)
        {
            return _teacherCourseBusinessService.InsertTeacherCourse(teacherCourse);
        }

        //Update TeacherCourse
        [HttpPut]
        public TeacherCourse? UpdateTeacherCourse(TeacherCourse teacherCourse)
        {
            return _teacherCourseBusinessService.UpdateTeacherCourse(teacherCourse);
        }

        //Delete TeacherCourse
        [HttpDelete("{id}")]
        public bool DeleteTeacherCourse(long id)
        {
            return _teacherCourseBusinessService.DeleteTeacherCourse(id);
        }
    }
}