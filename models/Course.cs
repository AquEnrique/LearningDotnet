using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class Course
    {
        [Key]
        public int IdCourse { get; set; }
        public int IdCareer { get; set; }
        public string Name { get; set; }
        
        [ForeignKey(nameof(IdCareer))]
        public Career? Career {get;set;}

        public ICollection<TeacherCourse>? TeacherCourses {get;set;}
    }
}