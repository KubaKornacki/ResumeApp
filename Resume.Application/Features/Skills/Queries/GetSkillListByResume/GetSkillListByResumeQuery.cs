using MediatR;

namespace ResumeApp.Application.Features.Skills.Queries.GetSkillListByResume;

public class GetSkillListByResumeQuery : IRequest<List<GetSkillListByResumeVm>>
{
    public Guid ResumeId { get; set; }
}
