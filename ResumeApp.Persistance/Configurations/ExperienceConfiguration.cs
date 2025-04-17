using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Persistence.Configurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.Property(e => e.StartDatetime)
                .IsRequired();

            builder.Property(e => e.EndDatetime)
                .IsRequired();

            builder.Property(e => e.Company)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Company)
                .IsRequired();
        }
    }
}
