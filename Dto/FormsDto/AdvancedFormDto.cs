using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPloyClasses.Dto.FormsDto
{
    public class AdvancedFormDto
    {
        // Personal Information
        public required string FullName { get; set; }
        public required string EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LinkedInProfile { get; set; }
        public string? GitHubProfile { get; set; }

        // Motivation
        public required string Inspiration { get; set; }
        public string? ProudProjectDescription { get; set; }
        public string? EnjoymentDescription { get; set; }
        public required string LearningMotivation { get; set; }

        // Adherence to Company Mission
        public required string MissionAdherence { get; set; }
        public string? TeamExperienceDescription { get; set; }

        // Technical Knowledge
        public required string PythonProficiency { get; set; }
        public required string JavaProficiency { get; set; }
        public required string CSharpProficiency { get; set; }
        public required string SQLProficiency { get; set; }

        // Additional Information
        public DateTime StartDate { get; set; }
        public string? AdditionalInformation { get; set; }
    }
}
