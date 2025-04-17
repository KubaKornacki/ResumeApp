using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Commands.CreateResume
{
    public class CreateResumeCommandHandler : IRequestHandler<CreateResumeCommand, Guid>
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly IMapper _mapper;

        public CreateResumeCommandHandler(IResumeRepository resumeRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateResumeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateResumeCommandValidator();

            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var resume = _mapper.Map<Resume>(request);

            resume = await _resumeRepository.AddAsync(resume);

            return resume.ResumeId;
        }
    }
}
