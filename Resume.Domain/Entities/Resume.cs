
namespace ResumeApp.Domain.Entities;

public class Resume
{
    public Guid ResumeId { get; set; }
    public string Name { get; set; } = null!;
    public string? AboutMe { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? LinkedinLink { get; set; }
    public string? GithubLink { get; set; }

    public ICollection<Education>? Educations { get; set; }
    public ICollection<Experience>? Experience { get; set; }
    public ICollection<Language>? Languages { get; set; }
    public ICollection<Skill>? Skills { get; set; }

}

