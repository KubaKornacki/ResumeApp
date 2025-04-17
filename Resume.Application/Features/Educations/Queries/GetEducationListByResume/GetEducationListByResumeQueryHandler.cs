using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;

namespace ResumeApp.Application.Features.Educations.Queries.GetEducationListByResume;

public class GetEducationListByResumeQueryHandler : IRequestHandler<GetEducationListByResumeQuery, List<GetEducationListByResumeVm>>
{

    private readonly IEducationRepository _educationRepository;
    private readonly IMapper _mapper;


    public GetEducationListByResumeQueryHandler(IEducationRepository educationRepository, IMapper mapper)
    {
        _educationRepository = educationRepository;
        _mapper = mapper;
    }
    public async Task<List<GetEducationListByResumeVm>> Handle(GetEducationListByResumeQuery request, CancellationToken cancellationToken)
    {
        var allResumeEducations = await _educationRepository.GetAllByResumeIdAsync(request.ResumeId);

        return _mapper.Map<List<GetEducationListByResumeVm>>(allResumeEducations);
    }
}
