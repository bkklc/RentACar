using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            // Primary Key
            builder.HasKey(co => co.Id);

            // Name -> Required + MaxLength(100)
            builder.Property(co => co.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Country → CustomerAddress (One-to-Many)
            builder.HasMany(co => co.Addresses)
                   .WithOne(ca => ca.Country)
                   .HasForeignKey(ca => ca.CountryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
