using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class StudentCourse
    {
        [Key]
        public long IdStudentCourse { get; set; }
        public long IdStudent { get; set; }
        public long IdTeacherCourse { get; set; }
        public float? Grade1 { get; set; }
        public float? Grade2 { get; set; }
        public float? Grade3 { get; set; }

        [ForeignKey(nameof(IdStudent))]
        public Student? Student { get; set; }

        [ForeignKey(nameof(IdTeacherCourse))]
        public TeacherCourse? TeacherCourse { get; set; }
    }
}