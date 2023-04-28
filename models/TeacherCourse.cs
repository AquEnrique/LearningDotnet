using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class TeacherCourse
    {
        [Key]
        public long IdTeacherCourse { get; set; }
        public long IdTeacher { get; set; }
        public long IdSemester { get; set; }
        public long IdCourse { get; set; }

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