using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Application.Exceptions;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class GetResumeWithDetailsQueryHandler : IRequestHandler<GetResumeWithDetailsQuery, GetResumeWithDetailsVm>
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly IResumeElementRepository<Education> _educationRepository;
        private readonly IResumeElementRepository<Experience> _experienceRepository;
        private readonly IResumeElementRepository<Language> _languageRepository;
        private readonly IResumeElementRepository<Skill> _skillRepository;
        private readonly IMapper _mapper;

        public GetResumeWithDetailsQueryHandler(IResumeRepository resumeRepository, IMapper mapper, IResumeElementRepository<Education> educationRepository,
            IResumeElementRepository<Experience> experienceRepository, IResumeElementRepository<Language> languageRepository, IResumeElementRepository<Skill> skillRepository)
        {
            _resumeRepository = resumeRepository;
            _mapper = mapper;
            _educationRepository = educationRepository;
            _experienceRepository = experienceRepository;
            _languageRepository = languageRepository;
            _skillRepository = skillRepository;
        }
        public async Task<GetResumeWithDetailsVm> Handle(GetResumeWithDetailsQuery request, CancellationToken cancellationToken)
        {
            var resume = await _resumeRepository.GetByIdAsync(request.ResumeId);

            if (resume is null)
                throw new NotFoundException(nameof(Resume), request.ResumeId);

            var resumeDto = _mapper.Map<GetResumeWithDetailsVm>(resume);
            resumeDto.Educations = _mapper.Map<List<EducationDto>>(await _educationRepository.GetAllByResumeIdAsync(request.ResumeId));
            resumeDto.Experience = _mapper.Map<List<ExperienceDto>>(await _experienceRepository.GetAllByResumeIdAsync(request.ResumeId));
            resumeDto.Languages = _mapper.Map<List<LanguageDto>>(await _languageRepository.GetAllByResumeIdAsync(request.ResumeId));
            resumeDto.Skills = _mapper.Map<List<SkillDto>>(await _skillRepository.GetAllByResumeIdAsync(request.ResumeId));

            return resumeDto;

        }
    }
}
