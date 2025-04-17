using AutoMapper;
using MediatR;
using ResumeApp.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeList
{
    public class GetResumeListQueryHandler : IRequestHandler<GetResumeListQuery, List<GetResumeListVm>>
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly IMapper _mapper;

        public GetResumeListQueryHandler(IResumeRepository resumeRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;
            _mapper = mapper;
        }
        public async Task<List<GetResumeListVm>> Handle(GetResumeListQuery request, CancellationToken cancellationToken)
        {
            var resumeList = await _resumeRepository.ListAllAsync();

            return _mapper.Map<List<GetResumeListVm>>(resumeList);
        }
    }
}
