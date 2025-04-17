using AutoMapper;
using ResumeApp.Application.Features.Languages.Queries.GetLanguagesListByResume;
using ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Profiles;

public class LanguageProfile:Profile
{
    public LanguageProfile()
    {
        CreateMap<Language, GetLanguagesListByResumeVm>().ReverseMap();
        CreateMap<Language, LanguageDto>();
    }
}
