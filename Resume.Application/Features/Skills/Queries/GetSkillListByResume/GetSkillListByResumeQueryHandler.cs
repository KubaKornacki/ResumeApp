using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;

namespace ResumeApp.Application.Features.Skills.Queries.GetSkillListByResume;

public class GetSkillListByResumeQueryHandler : IRequestHandler<GetSkillListByResumeQuery, List<GetSkillListByResumeVm>>
{

    private readonly ISkillRepository _skillRepository;
    private readonly IMapper _mapper;


    public GetSkillListByResumeQueryHandler(ISkillRepository skillRepository, IMapper mapper)
    {
        _skillRepository = skillRepository;
        _mapper = mapper;
    }
    public async Task<List<GetSkillListByResumeVm>> Handle(GetSkillListByResumeQuery request, CancellationToken cancellationToken)
    {
        var allResumeSkills = await _skillRepository.GetAllByResumeIdAsync(request.ResumeId);

        return _mapper.Map<List<GetSkillListByResumeVm>>(allResumeSkills);
    }
}
