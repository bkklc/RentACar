using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class WheelDriveTypeConfiguration : IEntityTypeConfiguration<WheelDriveType>
    {
        public void Configure(EntityTypeBuilder<WheelDriveType> builder)
        {
            // Primary Key
            builder.HasKey(wd => wd.Id);

            // Name -> Required + MaxLength(50)
            builder.Property(wd => wd.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Car → WheelDriveType (Many-to-One)
            builder.HasMany(wd => wd.Cars)
                   .WithOne(c => c.WheelDriveType)
                   .HasForeignKey(c => c.WheelDriveTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
