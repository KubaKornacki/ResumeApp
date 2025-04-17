using MediatR;

namespace ResumeApp.Application.Features.Educations.Queries.GetEducationListByResume;

public class GetEducationListByResumeQuery : IRequest<List<GetEducationListByResumeVm>>
{
    public Guid ResumeId { get; set; }
}
