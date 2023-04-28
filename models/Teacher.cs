using System.ComponentModel.DataAnnotations;

namespace NotasApi.models
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<TeacherCourse>? TeacherCourses {get;set;}
    }
}