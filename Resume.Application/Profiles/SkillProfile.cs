using AutoMapper;
using ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails;
using ResumeApp.Application.Features.Skills.Queries.GetSkillListByResume;
using ResumeApp.Domain.Entities;


namespace ResumeApp.Application.Profiles;

public class SkillProfile:Profile
{
    public SkillProfile()
    {
        CreateMap<Skill, GetSkillListByResumeVm>().ReverseMap();
        CreateMap<Skill, SkillDto>();
    }
}
