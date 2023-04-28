using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class StudentDataService
    {
        private Context _context;
        public StudentDataService(Context context)
        {
            _context = context;
        }

        // Get Students
        public IList<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        //Get one Student
        public Student? GetStudent(long id)
        {
            var Student = _context.Students.Find(id);
            return Student;
        }

        //Insert Student
        public Student InsertStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        //Update Student
        public Student? UpdateStudent(Student student)
        {
            var StudentDbo = _context.Students.Find(student.IdStudent);

            if (StudentDbo == null) return null;

            StudentDbo.Name = student.Name;
            StudentDbo.LastName = student.LastName;
            _context.SaveChanges();
            return StudentDbo;
        }

        //Delete Student
        public bool DeleteStudent(long id)
        {
            var StudentDbo = _context.Students.Find(id);
            if (StudentDbo == null) return false;

            _context.Students.Remove(StudentDbo);
            _context.SaveChanges();
            return true;
        }
    }
}
