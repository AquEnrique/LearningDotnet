using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasApi.models
{
    public class Career
    {
        [Key]
        public long IdCareer { get; set; }
        public string Name { get; set; }
        public long IdProfSchool { get; set; }

        [ForeignKey(nameof(IdProfSchool))]
        public ProfessionalSchool? ProfessionalSchool {get;set;}

        public ICollection<Course>? Courses {get;set;}
    }
}