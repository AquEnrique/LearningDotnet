using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;

namespace NotasApi.DataService
{
    public class TeacherDataService
    {
        private Context _context;

        public TeacherDataService(Context context)
        {
            _context = context;
        }

        // Get Teachers
        public IEnumerable<Teacher> GetTeachers()
        {
            return _context.Teachers.ToList();
        }

        //Get one Teacher
        public Teacher? GetTeacher(long id)
        {
            var Teacher = _context.Teachers.Find(id);
            return Teacher;
        }

        //Insert Teacher
        public Teacher InsertTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        //Update Teacher
        public Teacher? UpdateTeacher(Teacher teacher)
        {
            var TeacherDbo = _context.Teachers.Find(teacher.IdTeacher);

            if (TeacherDbo == null) return null;

            TeacherDbo.Name = teacher.Name;
            TeacherDbo.LastName = teacher.LastName;
            _context.SaveChanges();
            return TeacherDbo;
        }

        //Delete Teacher
        public bool DeleteTeacher(long id)
        {
            var TeacherDbo = _context.Teachers.Find(id);
            if (TeacherDbo == null) return false;

            _context.Teachers.Remove(TeacherDbo);
            _context.SaveChanges();
            return true;
        }
    }
}