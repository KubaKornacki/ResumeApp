using ResumeApp.Domain.Common;

namespace ResumeApp.Domain.Entities;

public class Experience : PeriodEntity
{
    public int ExperienceId { get; set; }
    public string Company { get; set; } = null!;
    public string Description { get; set; } = null!;
}

