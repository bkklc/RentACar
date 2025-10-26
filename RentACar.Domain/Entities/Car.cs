using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Car: BaseEntity<Guid>
    {
        public Guid BrandId { get; set; }    
        public Guid ModelId { get; set; }
        public Guid SerieId { get; set; }
        public Guid SeatCapacityId { get; set; }
        public Guid BodyTypeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid DoorTypeId { get; set; }
        public Guid FuelTypeId { get; set; }
        public Guid GearTypeId { get; set; }
        public Guid WheelDriveTypeId { get; set; }
        public Guid ModelYearId { get; set; }
        public int EnginePower { get; set; }
        public int EngineCapacity { get; set; }
        public int TrunkCapacity { get; set; }
        public string Description { get; set; }
        public string Plate { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }               
        public bool IsAvailable { get; set; } = true;

        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public Serie Serie { get; set; }
        public SeatCapacity SeatCapacity { get; set; }
        public BodyType BodyType { get; set; }
        public Color Color { get; set; }
        public DoorType DoorType { get; set; }
        public FuelType FuelType { get; set; }
        public GearType GearType { get; set; }
        public WheelDriveType WheelDriveType { get; set; }
        public ModelYear ModelYear { get; set; }


        public List<Rental> Rentals { get; set; } = new();



    }
}
