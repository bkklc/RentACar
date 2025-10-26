using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // Primary Key
            builder.HasKey(ci => ci.Id);

            // Name -> Required + MaxLength(100)
            builder.Property(ci => ci.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // City → CustomerAddress (One-to-Many)
            builder.HasMany(ci => ci.Addresses)
                   .WithOne(ca => ca.City)
                   .HasForeignKey(ca => ca.CityId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
