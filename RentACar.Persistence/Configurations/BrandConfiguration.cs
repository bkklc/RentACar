using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            // Primary Key
            builder.HasKey(b => b.Id);

            // Name -> Required + MaxLength(100)
            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Brand → Model (One-to-Many)
            builder.HasMany(b => b.Models)
                   .WithOne(m => m.Brand)
                   .HasForeignKey(m => m.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Brand → Car (One-to-Many)
            builder.HasMany(b => b.Cars)
                   .WithOne(c => c.Brand)
                   .HasForeignKey(c => c.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
