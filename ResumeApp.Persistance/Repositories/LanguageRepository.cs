using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence.Repositories
{
    public class LanguageRepository : ResumeElementRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(ResumeAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
