using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            // Primary Key
            builder.HasKey(ca => ca.Id);

            // AddressLine -> Required + MaxLength(255)
            builder.Property(ca => ca.AddressLine)
                   .IsRequired()
                   .HasMaxLength(255);

            // PostalCode -> Required + MaxLength(20)
            builder.Property(ca => ca.PostalCode)
                   .IsRequired()
                   .HasMaxLength(20);

            // CustomerAddress → Customer (Many-to-One)
            builder.HasOne(ca => ca.Customer)
                   .WithMany(cu => cu.Addresses)
                   .HasForeignKey(ca => ca.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // CustomerAddress → City (Many-to-One)
            builder.HasOne(ca => ca.City)
                   .WithMany(ci => ci.Addresses)
                   .HasForeignKey(ca => ca.CityId)
                   .OnDelete(DeleteBehavior.Restrict);

            // CustomerAddress → Country (Many-to-One)
            builder.HasOne(ca => ca.Country)
                   .WithMany(co => co.Addresses)
                   .HasForeignKey(ca => ca.CountryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
