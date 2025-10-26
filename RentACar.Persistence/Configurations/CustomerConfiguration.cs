using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Primary Key
            builder.HasKey(cu => cu.Id);

            // FirstName -> Required + MaxLength(100)
            builder.Property(cu => cu.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            // LastName -> Required + MaxLength(100)
            builder.Property(cu => cu.LastName)
                   .IsRequired()
                   .HasMaxLength(100);

            // Email -> Required + MaxLength(150)
            builder.Property(cu => cu.Email)
                   .IsRequired()
                   .HasMaxLength(150);

            // PhoneNumber -> Required + MaxLength(20)
            builder.Property(cu => cu.Phone)
                   .IsRequired()
                   .HasMaxLength(20);

            // Customer → CustomerAddress (One-to-Many)
            builder.HasMany(cu => cu.Addresses)
                   .WithOne(ca => ca.Customer)
                   .HasForeignKey(ca => ca.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Customer → Rental (One-to-Many)
            builder.HasMany(cu => cu.Rentals)
                   .WithOne(r => r.Customer)
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
