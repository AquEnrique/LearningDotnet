using System.ComponentModel.DataAnnotations;

namespace NotasApi.models
{
    public class ProfessionalSchool
    {
        [Key]
        public int IdProfSchool { get; set; }
        public string Name { get; set; }

        public ICollection<Career>? Careers {get;set;}
    }
}