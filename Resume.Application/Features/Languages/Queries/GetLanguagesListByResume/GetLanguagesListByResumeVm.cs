namespace ResumeApp.Application.Features.Languages.Queries.GetLanguagesListByResume;

public class GetLanguagesListByResumeVm
{
    public int LanguageId { get; set; }
    public string Name { get; set; } = null!;
    public int Proficiency { get; set; }
}
