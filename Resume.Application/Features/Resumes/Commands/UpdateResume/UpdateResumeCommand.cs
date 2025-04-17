using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Commands.UpdateResume
{
    public class UpdateResumeCommand:IRequest
    {
        public Guid ResumeId { get; set; }
        public string Name { get; set; } = null!;
        public string? AboutMe { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LinkedinLink { get; set; }
        public string? GithubLink { get; set; }
    }
}
