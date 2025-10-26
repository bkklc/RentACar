using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            // Primary Key
            builder.HasKey(co => co.Id);

            // Name -> Required + MaxLength(50)
            builder.Property(co => co.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Car → Color (Many-to-One)
            builder.HasMany(co => co.Cars)
                   .WithOne(c => c.Color)
                   .HasForeignKey(c => c.ColorId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
