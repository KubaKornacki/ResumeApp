

using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Application.Exceptions;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Features.Resumes.Commands.DeleteResume
{
    public class DeleteResumeCommandHandler : IRequestHandler<DeleteResumeCommand>
    {
        private readonly IResumeRepository _resumeRepository;
        public DeleteResumeCommandHandler(IResumeRepository resumeRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;

        }
        public async Task Handle(DeleteResumeCommand request, CancellationToken cancellationToken)
        {
            var resumeToDelete = await _resumeRepository.GetByIdAsync(request.ResumeId);

            if(resumeToDelete is null)
                throw new NotFoundException(nameof(Resume),request.ResumeId);

            await _resumeRepository.DeleteAsync(resumeToDelete);
        }
    }
}
