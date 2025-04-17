using ResumeApp.Domain.Common;


namespace ResumeApp.Domain.Entities;

public class Education : PeriodEntity
{
    public int EducationId { get; set; }
    public string School { get; set; } = null!;
}

