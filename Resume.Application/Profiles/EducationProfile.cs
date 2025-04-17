using AutoMapper;
using ResumeApp.Application.Features.Educations.Queries.GetEducationListByResume;
using ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Profiles;

public class EducationProfile : Profile
{
    public EducationProfile()
    {
        CreateMap<Education, GetEducationListByResumeVm>().ReverseMap();
        CreateMap<Education, EducationDto>();
    }
}
