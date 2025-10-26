using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class GearTypeConfiguration : IEntityTypeConfiguration<GearType>
    {
        public void Configure(EntityTypeBuilder<GearType> builder)
        {
            // Primary Key
            builder.HasKey(gt => gt.Id);

            // Name -> Required + MaxLength(50)
            builder.Property(gt => gt.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Car → GearType (Many-to-One)
            builder.HasMany(gt => gt.Cars)
                   .WithOne(c => c.GearType)
                   .HasForeignKey(c => c.GearTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
