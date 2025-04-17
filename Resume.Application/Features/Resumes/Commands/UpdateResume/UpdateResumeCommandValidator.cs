using FluentValidation;
using ResumeApp.Application.Features.Resumes.Commands.CreateResume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Commands.UpdateResume
{
    public class UpdateResumeCommandValidator: AbstractValidator<UpdateResumeCommand>
    {
        public UpdateResumeCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.PhoneNumber)
                .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 characters.");

            RuleFor(p => p.Email)
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.LinkedinLink)
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

            RuleFor(p => p.GithubLink)
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

        }
    }
}
