using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class StudentCourseBusinessService
    {
        private StudentCourseDataService _studentCourseDataService;
        public StudentCourseBusinessService(StudentCourseDataService studentCourseDataService)
        {
            _studentCourseDataService = studentCourseDataService;
        }

        // Get StudentCourses
        public IEnumerable<StudentCourse> GetStudentCourses()
        {
            return _studentCourseDataService.GetStudentCourses();
        }

        //Get one StudentCourse
        public StudentCourse? GetStudentCourse(long id)
        {
            return _studentCourseDataService.GetStudentCourse(id);
        }

        //Insert StudentCourse
        public StudentCourse InsertStudentCourse(StudentCourse studentCourse)
        {
            return _studentCourseDataService.InsertStudentCourse(studentCourse);
        }

        //Update StudentCourse
        public StudentCourse? UpdateStudentCourse(StudentCourse studentCourse)
        {
            return _studentCourseDataService.UpdateStudentCourse(studentCourse);
        }

        //Delete StudentCourse
        public bool DeleteStudentCourse(long id)
        {
            return _studentCourseDataService.DeleteStudentCourse(id);
        }
    }
}