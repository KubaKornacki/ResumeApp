using MediatR;
using ResumeApp.Application.Features.Skills.Queries.GetSkillListByResume;


namespace ResumeApp.Application.Features.Experiences.Queries.GetExperienceListByResume;

public class GetSkillListByResumeQuery : IRequest<List<GetSkillListByResumeVm>>
{
    public Guid ResumeId { get; set; }
}
