

using ResumeApp.Domain.Common;

namespace ResumeApp.Domain.Entities;

public class Language:ResumeElementEntity
{
    public int LanguageId { get; set; }
    public string Name { get; set; } = null!;
    public int Proficiency { get; set; }
}

