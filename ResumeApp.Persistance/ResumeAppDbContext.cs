using Microsoft.EntityFrameworkCore;
using ResumeApp.Application.Contracts;
using ResumeApp.Domain.Common;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence
{
    public class ResumeAppDbContext:DbContext
    {
        private readonly ILoggedInUserService? _loggedInUserService;
        public ResumeAppDbContext(DbContextOptions<ResumeAppDbContext> options):base(options)
        {
            
        }

        public ResumeAppDbContext(DbContextOptions<ResumeAppDbContext> options, ILoggedInUserService? loggedInUserService) : base(options)
        {
            _loggedInUserService = loggedInUserService;
        }


        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Skill> Skills { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = _loggedInUserService.UserId;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
