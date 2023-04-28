using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class StudentCourse
    {
        [Key]
        public int IdStudentCourse { get; set; }
        public int IdStudent { get; set; }
        public int IdTeacherCourse { get; set; }
        public float? Grade1 { get; set; }
        public float? Grade2 { get; set; }
        public float? Grade3 { get; set; }

        [ForeignKey(nameof(IdStudent))]
        public Student? Student { get; set; }

        [ForeignKey(nameof(IdTeacherCourse))]
        public TeacherCourse? TeacherCourse { get; set; }
    }
}