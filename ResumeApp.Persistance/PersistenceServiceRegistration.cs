using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.Application.Contracts.Persistence;
using ResumeApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ResumeAppDbContext>(options=>options.UseSqlServer(configuration.GetConnectionString("ResumeAppConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>),typeof(BaseRepository<>));

            services.AddScoped(typeof(IResumeElementRepository<>), typeof(ResumeElementRepository<>));

            services.AddScoped<IResumeRepository, ResumeRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IExperienceRepository, ExperienceRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            return services;
        }
    }
}
