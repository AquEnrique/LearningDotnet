using System.ComponentModel.DataAnnotations;

namespace NotasApi.models
{
    public class Semester
    {
        [Key]
        public int IdSemester { get; set; }
        public string NameSemester { get; set; }

        public ICollection<TeacherCourse>? TeacherCourses {get;set;}
    }
}