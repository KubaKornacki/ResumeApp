using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class ExperienceDto
    {
        public int ExperienceId { get; set; }
        public string Company { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
