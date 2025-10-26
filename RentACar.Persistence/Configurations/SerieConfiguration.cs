using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class SerieConfiguration : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            // Primary Key
            builder.HasKey(s => s.Id);

            // Name -> Required + MaxLength(100)
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Serie → Model (Many-to-One)
            builder.HasOne(s => s.Model)
                   .WithMany(m => m.Series)
                   .HasForeignKey(s => s.ModelId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Serie → Car (One-to-Many)
            builder.HasMany(s => s.Cars)
                   .WithOne(c => c.Serie)
                   .HasForeignKey(c => c.SerieId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

