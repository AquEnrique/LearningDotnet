using System.ComponentModel.DataAnnotations;

namespace NotasApi.models
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<Review>? Reviews {get;set;}
        public ICollection<StudentCourse>? StudentCourses {get;set;}
    }
}