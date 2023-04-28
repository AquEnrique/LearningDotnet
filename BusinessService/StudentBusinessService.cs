using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.DataService;
using NotasApi.models;

namespace NotasApi.BusinessService
{

    public class StudentBusinessService
    {
        private StudentDataService _studentDataService;
        public StudentBusinessService(StudentDataService studentDataService)
        {
            _studentDataService = studentDataService;
        }

        public IList<Student> GetStudents()
        {
            return _studentDataService.GetStudents();
        }
        
                //Get one Student
        public Student? GetStudent(long id)
        {
            return _studentDataService.GetStudent(id);
         }

        //Insert Student
        public Student InsertStudent(Student student)
        {
            return _studentDataService.InsertStudent(student);
        }

        //Update Student
        public Student? UpdateStudent(Student student)
        {
            return _studentDataService.UpdateStudent(student);
        }

        //Delete Student
        public bool DeleteStudent(long id)
        {
            return _studentDataService.DeleteStudent(id);
        }
    }
}