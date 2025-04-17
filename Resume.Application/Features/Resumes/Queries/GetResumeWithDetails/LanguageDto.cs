using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class LanguageDto
    {
        public int LanguageId { get; set; }
        public string Name { get; set; } = null!;
        public int Proficiency { get; set; }
    }
}
