using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class BodyTypeConfiguration : IEntityTypeConfiguration<BodyType>
    {
        public void Configure(EntityTypeBuilder<BodyType> builder)
        {
            // Primary Key
            builder.HasKey(bt => bt.Id);

            // Name -> Required + MaxLength(50)
            builder.Property(bt => bt.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Car → BodyType (Many-to-One)
            builder.HasMany(bt => bt.Cars)
                   .WithOne(c => c.BodyType)
                   .HasForeignKey(c => c.BodyTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
