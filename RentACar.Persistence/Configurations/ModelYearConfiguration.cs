using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class ModelYearConfiguration : IEntityTypeConfiguration<ModelYear>
    {
        public void Configure(EntityTypeBuilder<ModelYear> builder)
        {
            // Primary Key
            builder.HasKey(my => my.Id);

            // Year -> Required
            builder.Property(my => my.Year)
                   .IsRequired();

            // Car → ModelYear (Many-to-One)
            builder.HasMany(my => my.Cars)
                   .WithOne(c => c.ModelYear)
                   .HasForeignKey(c => c.ModelYearId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
