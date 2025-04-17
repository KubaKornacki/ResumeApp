using ResumeApp.Domain.Common;

namespace ResumeApp.Domain.Entities;

public class Skill:ResumeElementEntity
{
    public Guid SkillId { get; set; }
    public string Name { get; set; } = null!;
    public int Level { get; set; }
}

