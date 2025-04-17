using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence.Configurations
{
    public class EducationConfigration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.Property(e => e.StartDatetime)
                .IsRequired();

            builder.Property(e => e.EndDatetime)
                .IsRequired();

            builder.Property(e => e.School)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
