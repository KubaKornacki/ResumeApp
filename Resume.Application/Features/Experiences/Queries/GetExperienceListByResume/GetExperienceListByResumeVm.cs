namespace ResumeApp.Application.Features.Experiences.Queries.GetExperienceListByResume;

public class GetExperienceListByResumeVm
{
    public int ExperienceId { get; set; }
    public string Company { get; set; } = null!;
    public string Description { get; set; } = null!;
}
