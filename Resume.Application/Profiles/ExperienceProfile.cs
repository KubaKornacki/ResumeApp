using AutoMapper;
using ResumeApp.Application.Features.Experiences.Queries.GetExperienceListByResume;
using ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails;
using ResumeApp.Domain.Entities;


namespace ResumeApp.Application.Profiles;

public class ExperienceProfile : Profile
{
    public ExperienceProfile()
    {
        CreateMap<Experience, GetExperienceListByResumeVm>().ReverseMap();
        CreateMap<Experience, ExperienceDto>();
    }
}
