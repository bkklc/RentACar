using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class DoorTypeConfiguration : IEntityTypeConfiguration<DoorType>
    {
        public void Configure(EntityTypeBuilder<DoorType> builder)
        {
            // Primary Key
            builder.HasKey(dt => dt.Id);

            // DoorCount -> Required
            builder.Property(dt => dt.DoorCount)
                   .IsRequired();

            // Car → DoorType (Many-to-One)
            builder.HasMany(dt => dt.Cars)
                   .WithOne(c => c.DoorType)
                   .HasForeignKey(c => c.DoorTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
