﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails
{
    public class GetResumeWithDetailsQuery : IRequest<GetResumeWithDetailsVm>
    {
        public Guid ResumeId { get; set; }
    }
}
