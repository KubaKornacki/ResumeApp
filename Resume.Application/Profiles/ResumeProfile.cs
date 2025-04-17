using AutoMapper;
using ResumeApp.Application.Features.Resumes.Commands.CreateResume;
using ResumeApp.Application.Features.Resumes.Commands.UpdateResume;
using ResumeApp.Application.Features.Resumes.Queries.GetResumeList;
using ResumeApp.Application.Features.Resumes.Queries.GetResumeWithDetails;
using ResumeApp.Domain.Entities;


namespace ResumeApp.Application.Profiles;

public class ResumeProfile:Profile
{
    public ResumeProfile()
    {
        CreateMap<Resume, GetResumeListVm>().ReverseMap();
        CreateMap<Resume, GetResumeWithDetailsVm>().ReverseMap();
        CreateMap<Resume, CreateResumeCommand>().ReverseMap();
        CreateMap<Resume, UpdateResumeCommand>().ReverseMap();
    }
}
