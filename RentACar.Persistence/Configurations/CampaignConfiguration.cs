using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            // Primary Key
            builder.HasKey(ca => ca.Id);

            // Name -> Required + MaxLength(100)
            builder.Property(ca => ca.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Description -> Optional + MaxLength(500)
            builder.Property(ca => ca.Description)
                   .HasMaxLength(500);

            // DiscountRate -> Required
            builder.Property(ca => ca.DiscountRate)
                   .IsRequired();

            // StartDate -> Required
            builder.Property(ca => ca.StartDate)
                   .IsRequired();

            // EndDate -> Required
            builder.Property(ca => ca.EndDate)
                   .IsRequired();

            // Campaign → Rental (One-to-Many)
            builder.HasMany(ca => ca.Rentals)
                   .WithOne(r => r.Campaign)
                   .HasForeignKey(r => r.CampaignId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
