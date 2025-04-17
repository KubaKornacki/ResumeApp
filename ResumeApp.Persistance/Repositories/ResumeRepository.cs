using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence.Repositories
{
    public class ResumeRepository : BaseRepository<Resume>, IResumeRepository
    {
        public ResumeRepository(ResumeAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
