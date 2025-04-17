using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence.Configurations
{
    public class ResumeConfigration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e=>e.PhoneNumber)
                .HasMaxLength(15);

            builder.Property(e => e.Email)
                .HasMaxLength(50);

            builder.Property(e => e.LinkedinLink)
                .HasMaxLength(100);

            builder.Property(e => e.GithubLink)
                .HasMaxLength(100);
        }
    }
}
