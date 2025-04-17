using ResumeApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Contracts.Persistence
{
    public interface IResumeElementRepository<T>:IAsyncRepository<T> where T : ResumeElementEntity
    {
       public Task<IReadOnlyList<T>?> GetAllByResumeIdAsync(Guid ResumeId);
    }
}
