using Microsoft.EntityFrameworkCore;
using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence.Repositories
{
    public class ResumeElementRepository<T> : BaseRepository<T>, IResumeElementRepository<T> where T : ResumeElementEntity
    {

        public ResumeElementRepository(ResumeAppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<T>?> GetAllByResumeIdAsync(Guid ResumeId)
        {
            var elements= await _dbContext.Set<T>().ToListAsync();

            return elements.Where(x => x.ResumeId == ResumeId).ToList();
        }
    }
}
