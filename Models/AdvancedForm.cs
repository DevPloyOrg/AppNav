
using System.ComponentModel.DataAnnotations;

namespace DevPloyClasses.Models
{
    public class AdvancedForm 
    {
        [Key]
        public int Id { get; set; }

        // Personal Information
        [Required]
        public required string FullName { get; set; }
        [Required]
        [EmailAddress]
        public required string EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        [Url]
        public string? LinkedInProfile { get; set; }
        [Url]
        public string? GitHubProfile { get; set; }

        // Motivation
        [Required]
        public required string Inspiration { get; set; }
        [Required]
        public string? ProudProjectDescription { get; set; }
        public string? EnjoymentDescription { get; set; }
        [Required]
        public required string LearningMotivation { get; set; }

        // Adherence to Company Mission
        [Required]
        public required string MissionAdherence { get; set; }
        public string? TeamExperienceDescription { get; set; }

        // Technical Knowledge
        [Required]
        public required string PythonProficiency { get; set; }
        [Required]
        public required string JavaProficiency { get; set; }
        [Required]
        public required string CSharpProficiency { get; set; }
        [Required]
        public required string SQLProficiency { get; set; }

        // Additional Information
        [Required]
        public DateTime StartDate { get; set; }
        public string? AdditionalInformation { get; set; }
    }

}