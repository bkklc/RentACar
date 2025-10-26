using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class SeatCapacityConfiguration : IEntityTypeConfiguration<SeatCapacity>
    {
        public void Configure(EntityTypeBuilder<SeatCapacity> builder)
        {
            // Primary Key
            builder.HasKey(sc => sc.Id);

            // SeatCount -> Required
            builder.Property(sc => sc.SeatCount)
                   .IsRequired();

            // Car → SeatCapacity (Many-to-One)
            builder.HasMany(sc => sc.Cars)
                   .WithOne(c => c.SeatCapacity)
                   .HasForeignKey(c => c.SeatCapacityId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
