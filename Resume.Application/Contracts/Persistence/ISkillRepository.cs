using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Contracts.Persistence
{
    public interface ISkillRepository: IResumeElementRepository<Skill>
    {
    }
}
