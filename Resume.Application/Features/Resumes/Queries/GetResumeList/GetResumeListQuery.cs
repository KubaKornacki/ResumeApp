using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeList
{
    public class GetResumeListQuery : IRequest<List<GetResumeListVm>>
    {
    }
}
