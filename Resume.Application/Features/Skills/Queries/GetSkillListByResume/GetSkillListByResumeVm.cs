namespace ResumeApp.Application.Features.Skills.Queries.GetSkillListByResume;

public class GetSkillListByResumeVm
{
    public Guid SkillId { get; set; }
    public string Name { get; set; } = null!;
    public int Level { get; set; }
}
