using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            // Primary Key
            builder.HasKey(c => c.Id);

            // Plate -> Required + MaxLength(20)
            builder.Property(c => c.Plate)
                   .IsRequired()
                   .HasMaxLength(20);

            // Car → Brand (Many-to-One)
            builder.HasOne(c => c.Brand)
                   .WithMany(b => b.Cars)
                   .HasForeignKey(c => c.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → Model (Many-to-One)
            builder.HasOne(c => c.Model)
                   .WithMany(m => m.Cars)
                   .HasForeignKey(c => c.ModelId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → Serie (Many-to-One)
            builder.HasOne(c => c.Serie)
                   .WithMany(s => s.Cars)
                   .HasForeignKey(c => c.SerieId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → SeatCapacity (Many-to-One)
            builder.HasOne(c => c.SeatCapacity)
                   .WithMany(sc => sc.Cars)
                   .HasForeignKey(c => c.SeatCapacityId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → BodyType (Many-to-One)
            builder.HasOne(c => c.BodyType)
                   .WithMany(bt => bt.Cars)
                   .HasForeignKey(c => c.BodyTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → Color (Many-to-One)
            builder.HasOne(c => c.Color)
                   .WithMany(co => co.Cars)
                   .HasForeignKey(c => c.ColorId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → DoorType (Many-to-One)
            builder.HasOne(c => c.DoorType)
                   .WithMany(dt => dt.Cars)
                   .HasForeignKey(c => c.DoorTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → FuelType (Many-to-One)
            builder.HasOne(c => c.FuelType)
                   .WithMany(ft => ft.Cars)
                   .HasForeignKey(c => c.FuelTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → GearType (Many-to-One)
            builder.HasOne(c => c.GearType)
                   .WithMany(gt => gt.Cars)
                   .HasForeignKey(c => c.GearTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → WheelDriveType (Many-to-One)
            builder.HasOne(c => c.WheelDriveType)
                   .WithMany(wd => wd.Cars)
                   .HasForeignKey(c => c.WheelDriveTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Car → ModelYear (Many-to-One)
            builder.HasOne(c => c.ModelYear)
                   .WithMany(my => my.Cars)
                   .HasForeignKey(c => c.ModelYearId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
