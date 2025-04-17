using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class GetResumeWithDetailsVm
    {
        public Guid ResumeId { get; set; }
        public string Name { get; set; } = null!;
        public string? AboutMe { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LinkedinLink { get; set; }
        public string? GithubLink { get; set; }

        public ICollection<EducationDto>? Educations { get; set; }
        public ICollection<ExperienceDto>? Experience { get; set; }
        public ICollection<LanguageDto>? Languages { get; set; }
        public ICollection<SkillDto>? Skills { get; set; }
    }
}
