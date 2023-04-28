using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class Career
    {
        [Key]
        public int IdCareer { get; set; }
        public string Name { get; set; }
        public int IdProfSchool { get; set; }

        [ForeignKey(nameof(IdProfSchool))]
        public ProfessionalSchool? ProfessionalSchool {get;set;}

        public ICollection<Course>? Courses {get;set;}
    }
}