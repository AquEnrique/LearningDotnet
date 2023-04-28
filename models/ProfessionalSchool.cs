using System.ComponentModel.DataAnnotations;

namespace NotasApi.models
{
    public class ProfessionalSchool
    {
        [Key]
        public long IdProfSchool { get; set; }
        public string Name { get; set; }

        public ICollection<Career>? Careers {get;set;}
    }
}