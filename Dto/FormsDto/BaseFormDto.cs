namespace DevPloyClasses.Dto.FormsDto
{
    public class BaseFormDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? LinkedIn { get; set; }
        public string? GitHub { get; set; }
        public string? SelectedProject { get; set; }
        public required string SkillExperience { get; set; }
        public required List<string> ProgrammingLanguages { get; set; }
    }
}
