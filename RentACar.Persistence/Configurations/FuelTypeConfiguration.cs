using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class FuelTypeConfiguration : IEntityTypeConfiguration<FuelType>
    {
        public void Configure(EntityTypeBuilder<FuelType> builder)
        {
            // Primary Key
            builder.HasKey(ft => ft.Id);

            // Name -> Required + MaxLength(50)
            builder.Property(ft => ft.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Car → FuelType (Many-to-One)
            builder.HasMany(ft => ft.Cars)
                   .WithOne(c => c.FuelType)
                   .HasForeignKey(c => c.FuelTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
