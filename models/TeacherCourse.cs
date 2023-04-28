using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class TeacherCourse
    {
        [Key]
        public int IdTeacherCourse { get; set; }
        public int IdTeacher { get; set; }
        public int IdSemester { get; set; }
        public int IdCourse { get; set; }

        [ForeignKey(nameof(IdTeacher))]
        public Teacher? Teacher {get;set;}

        [ForeignKey(nameof(IdSemester))]
        public Semester? Semester {get;set;}

        [ForeignKey(nameof(IdCourse))]
        public Course? Course {get;set;}

        public ICollection<Evaluation>? Evaluations {get;set;}
        public ICollection<StudentCourse>? StudentCourses {get;set;}
    }
}