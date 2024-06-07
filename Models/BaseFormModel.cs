using System.ComponentModel.DataAnnotations;

namespace DevPloyClasses.Models
{
    public class BaseFormModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Url]
        public string? LinkedIn { get; set; }

        [Url]
        public string? GitHub { get; set; }

        [Required]
        public string? SelectedProject { get; set; }

        [Required]
        public required string SkillExperience { get; set; }

        [Required]
        public  required List<string> ProgrammingLanguages { get; set; }
    }

}