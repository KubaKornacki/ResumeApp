using MediatR;


namespace ResumeApp.Application.Features.Languages.Queries.GetLanguagesListByResume;

public class GetLanguagesListByResumeQuery : IRequest<List<GetLanguagesListByResumeVm>>
{
    public Guid ResumeId { get; set; }
}
