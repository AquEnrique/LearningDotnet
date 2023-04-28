using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{
    public class TeacherBusinessService
    {
        private TeacherDataService _teacherDataService;
        public TeacherBusinessService(TeacherDataService teacherDataService)
        {
            _teacherDataService = teacherDataService;
        }

        // Get Teachers
        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacherDataService.GetTeachers();
        }

        //Get one Teacher
        public Teacher? GetTeacher(long id)
        {
            return _teacherDataService.GetTeacher(id);
        }

        //Insert Teacher
        public Teacher InsertTeacher(Teacher teacher)
        {
            return _teacherDataService.InsertTeacher(teacher);
        }

        //Update Teacher
        public Teacher? UpdateTeacher(Teacher teacher)
        {
            return _teacherDataService.UpdateTeacher(teacher);
        }

        //Delete Teacher
        public bool DeleteTeacher(long id)
        {            
            return _teacherDataService.DeleteTeacher(id);
        }
    }
}