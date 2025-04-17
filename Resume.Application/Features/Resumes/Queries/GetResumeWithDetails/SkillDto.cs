using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class SkillDto
    {
        public Guid SkillId { get; set; }
        public string Name { get; set; } = null!;
        public int Level { get; set; }
    }
}
