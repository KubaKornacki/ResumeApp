using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Application.Features.Skills.Queries.GetSkillListByResume;


namespace ResumeApp.Application.Features.Experiences.Queries.GetExperienceListByResume;

public class GetSkillListByResumeQueryHandler : IRequestHandler<GetSkillListByResumeQuery, List<GetSkillListByResumeVm>>
{

    private readonly IExperienceRepository _experienceRepository;
    private readonly IMapper _mapper;


    public GetSkillListByResumeQueryHandler(IExperienceRepository experienceRepository, IMapper mapper)
    {
        _experienceRepository = experienceRepository;
        _mapper = mapper;
    }
    public async Task<List<GetSkillListByResumeVm>> Handle(GetSkillListByResumeQuery request, CancellationToken cancellationToken)
    {
        var allResumeExperiences = await _experienceRepository.GetAllByResumeIdAsync(request.ResumeId);

        return _mapper.Map<List<GetSkillListByResumeVm>>(allResumeExperiences);
    }
}
