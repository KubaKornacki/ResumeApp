using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Domain.Common
{
    public class ResumeElementEntity
    {
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; } = null!;
    }
}
