using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class TeacherCourseBusinessService
    {
        private TeacherCourseDataService _teacherCourseDataService;
        public TeacherCourseBusinessService(TeacherCourseDataService teacherCourseDataService)
        {
            _teacherCourseDataService = teacherCourseDataService;
        }

        // Get TeacherCourses
        public IEnumerable<TeacherCourse> GetTeacherCourses()
        {
            return _teacherCourseDataService.GetTeacherCourses();
        }

        //Get one TeacherCourse
        public TeacherCourse? GetTeacherCourse(long id)
        {
            return _teacherCourseDataService.GetTeacherCourse(id);
        }

        //Insert TeacherCourse
        public TeacherCourse InsertTeacherCourse(TeacherCourse teacherCourse)
        {
            return _teacherCourseDataService.InsertTeacherCourse(teacherCourse);
        }

        //Update TeacherCourse
        public TeacherCourse? UpdateTeacherCourse(TeacherCourse teacherCourse)
        {
            return _teacherCourseDataService.UpdateTeacherCourse(teacherCourse);
        }

        //Delete TeacherCourse
        public bool DeleteTeacherCourse(long id)
        {
            return _teacherCourseDataService.DeleteTeacherCourse(id);
        }
    }
}