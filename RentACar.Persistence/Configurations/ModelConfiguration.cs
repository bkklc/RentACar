using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            // Primary Key
            builder.HasKey(m => m.Id);

            // Name -> Required + MaxLength(100)
            builder.Property(m => m.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Model → Brand (Many-to-One)
            builder.HasOne(m => m.Brand)
                   .WithMany(b => b.Models)
                   .HasForeignKey(m => m.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Model → Serie (One-to-Many)
            builder.HasMany(m => m.Series)
                   .WithOne(s => s.Model)
                   .HasForeignKey(s => s.ModelId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Model → Car (One-to-Many)
            builder.HasMany(m => m.Cars)
                   .WithOne(c => c.Model)
                   .HasForeignKey(c => c.ModelId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}