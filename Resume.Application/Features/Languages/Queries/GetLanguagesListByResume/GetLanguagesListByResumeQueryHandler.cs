using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;

namespace ResumeApp.Application.Features.Languages.Queries.GetLanguagesListByResume;

public class GetLanguagesListByResumeQueryHandler : IRequestHandler<GetLanguagesListByResumeQuery, List<GetLanguagesListByResumeVm>>
{
    private readonly ILanguageRepository _LanguageRepository;
    private readonly IMapper _mapper;

    public GetLanguagesListByResumeQueryHandler(ILanguageRepository languageRpository, IMapper mapper)
    {
        _LanguageRepository = languageRpository;
        _mapper = mapper;
    }

    public async Task<List<GetLanguagesListByResumeVm>> Handle(GetLanguagesListByResumeQuery request, CancellationToken cancellationToken)
    {
        var allResumeLanguages = await _LanguageRepository.GetAllByResumeIdAsync(request.ResumeId);

        return _mapper.Map<List<GetLanguagesListByResumeVm>>(allResumeLanguages);
    }
}
