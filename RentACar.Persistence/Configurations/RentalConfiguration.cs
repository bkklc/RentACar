using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            // Primary Key
            builder.HasKey(r => r.Id);

            // RentDate -> Required
            builder.Property(r => r.RentDate)
                   .IsRequired();          

            // DailyPrice -> Required
            builder.Property(r => r.DailyPrice)
                   .IsRequired();

            // TotalPrice -> Required
            builder.Property(r => r.TotalPrice)
                   .IsRequired();

            // IsActive -> Required
            builder.Property(r => r.IsActive)
                   .IsRequired();

            // Rental → Car (Many-to-One)
            builder.HasOne(r => r.Car)
                   .WithMany(c => c.Rentals)
                   .HasForeignKey(r => r.CarId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Rental → Customer (Many-to-One)
            builder.HasOne(r => r.Customer)
                   .WithMany(cu => cu.Rentals)
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Rental → Campaign (Many-to-One) 
            builder.HasOne(r => r.Campaign)
                   .WithMany(ca => ca.Rentals)
                   .HasForeignKey(r => r.CampaignId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
