using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class EducationDto
    {
        public int EducationId { get; set; }
        public string School { get; set; } = null!;
    }
}
