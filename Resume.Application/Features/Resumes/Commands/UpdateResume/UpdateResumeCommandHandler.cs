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

namespace ResumeApp.Application.Features.Resumes.Commands.UpdateResume
{
    public class UpdateResumeCommandHandler : IRequestHandler<UpdateResumeCommand>
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly IMapper _mapper;

        public UpdateResumeCommandHandler(IResumeRepository resumeRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;
            _mapper = mapper;
        }
        public async Task Handle(UpdateResumeCommand request, CancellationToken cancellationToken)
        {
            var resumeToUpdate = await _resumeRepository.GetByIdAsync(request.ResumeId);

            if (resumeToUpdate is null)
                throw new NotFoundException(nameof(Resume), request.ResumeId);

            var validator = new UpdateResumeCommandValidator();

            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var resume=_mapper.Map<Resume>(request);

            await _resumeRepository.UpdateAsync(resume);
        }
    }
}
